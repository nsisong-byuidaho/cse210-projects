using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public string GetRenderedText()
    {
        return string.Join(' ', _words.Select(word => word.Render()));
    }

    public override string ToString()
    {
        return $"{_reference}\n{GetRenderedText()}";
    }
}
