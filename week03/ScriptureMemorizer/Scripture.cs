public class Scripture
{
    private ScriptureReference _reference;
    private Word[] _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToArray();
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            var visibleWords = _words.Where(word => !word.IsHidden()).ToArray();
            if (visibleWords.Length == 0)
            {
                break;
            }
            var wordToHide = visibleWords[random.Next(visibleWords.Length)];
            wordToHide.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetReferenceString()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
