public class Reference
{
    private string _book;
    private uint _chapter;
    private uint _startVerse;
    private uint _endVerse;
    public Reference(string book, uint chapter, uint startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }
    public Reference(string book, uint chapter, uint startVerse, uint endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetRef()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
            } else {
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            }
        }
    }
