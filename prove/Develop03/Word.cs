using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string wordtext)
    {
        _text = wordtext;
    }
    public void Hide()
    {
       _isHidden = true;        
    }

    public void Show()
    {        
        _isHidden = false;
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //if it's not hidden, print the word.  If it is hidden, print underscores.//
        if (_isHidden == false)
        {
            return _text;
        }

        else
        {
            int length = _text.Length;
            string underscores = new string('_', length);

            return underscores;
        }

    }
}
