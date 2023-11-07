namespace API.Helpers
{
    public class PaginationHeader
    {

        public PaginationHeader(int currentPage, int totalItems, int itemsPerPage, int totalPages) 
        {
            this.CurrentPage = currentPage;
            this.TotalItems = totalItems;
            this.ItemsPerPage = itemsPerPage;
            this.TotalPages = totalPages;
        }
        public int CurrentPage { get; set; }
        public int ItemsPerPage {get; set;}
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}