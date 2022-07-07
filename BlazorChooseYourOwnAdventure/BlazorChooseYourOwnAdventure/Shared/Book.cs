namespace BlazorChooseYourOwnAdventure.Shared
{
    public class Book
    {
        public int _bookid { get; set; } = 0;
        public string? _booktitle { get; set; }
        public string? _bookdescription { get; set; }
        public List<int>? _bookpages { get; set; } = new List<int>();
        public string? _bookauthor { get; set; }
        public string? _bookcategory { get; set; }
    }
}
