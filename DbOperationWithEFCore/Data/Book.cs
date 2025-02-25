namespace DbOperationWithEFCore.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string NumberOfPages { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreateOn { get; set; } 
    }
}
