using System;

namespace API.Helpers
{
    //Used for the maximum page size
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1;
        public int _pagesize = 10;
        public int PageSize
        {

            get => _pagesize;
            set => _pagesize = (value > MaxPageSize) ? MaxPageSize:value;
        }
        public string CurrentUsername { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } =18;
        public int MaxAge { get; set; } = 150;

        public string OrderBy { get; set; } = "lastActive";

    }
}
