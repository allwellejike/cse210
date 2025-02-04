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

     public void HideRandomWords(int count = 3)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

     public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
