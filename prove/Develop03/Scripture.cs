using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
   
    private List<Word> _words = new List<Word>();
    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
    
        foreach (string currentWord in text.Split(" "))
        {
            Word newWord = new Word(currentWord);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        //should get a number of words to hide, iterate through the list of words and find out if its hidden already, then hide the number of words required//
        int numberOfWordsHidden = 0;

        Random randomGenerator = new Random();

        while (numberToHide > numberOfWordsHidden && IsCompletelyHidden() == false)
        {
            int wordIndex = randomGenerator.Next(0, _words.Count);

            if (_words[wordIndex].IsHidden() == false)
            {
                _words[wordIndex].Hide();
                numberOfWordsHidden += 1;
            }
        }   
    }

    public string GetDisplayText()
    {
        string verse = _reference.GetDisplayText();
        //should display the scripture with correct number of words hidden//
        foreach (Word word in _words)
        {
            verse += " ";
            verse += word.GetDisplayText();
            
        }

        return verse;
    }

    public bool IsCompletelyHidden()
    {
        //should end the program because the scripture is all blank//
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}