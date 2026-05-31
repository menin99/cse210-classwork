public class Scripture
{
    private Reference _reference;
    private List<Word> _text;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    public void Display()
    {
        Console.WriteLine(_reference.GetRef());
        Console.WriteLine(string.Join(" ", _text.Select(w => w.GetWord())));
            
    }
    public void HideRandomWords(int count = 3)
    {
        Random rand = new Random();
        List<Word> visible = _text.Where(w => !w.IsHidden()).ToList();
        int mustHide = Math.Min(count, visible.Count);
        for (int i=0;i<mustHide;i++)
        {
            int index = rand.Next(visible.Count);
            visible[index].HideWord();
            visible.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        return _text.All(w => w.IsHidden());
    }
}