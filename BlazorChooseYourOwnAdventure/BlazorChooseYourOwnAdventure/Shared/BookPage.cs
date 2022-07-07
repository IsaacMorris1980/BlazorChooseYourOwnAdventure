namespace BlazorChooseYourOwnAdventure.Shared
{
    public class BookPage
    {
        private int id = 0;
        private int BookId = 0;
        private int _pagenumber;
        public string _pagecontent;
        public bool _pageonrightpath;
        public string? _pagequestion;
        public string? _pageleftanswer;
        public string? _pagerightanswer;
        public bool? _pagecontainsimage;
        public string? _pageimagelocation;
        public ImageSide? _imageside;
    }
}
