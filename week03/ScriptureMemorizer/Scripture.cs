using System.Reflection.PortableExecutable;
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int visibleWords = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords++;
            }
        }

        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, visibleWords);
        int wordsHidden = 0;
        while (wordsHidden < wordsToHide)
        {
            int randomIndex = random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++; 
            }
        }
        

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
    
}