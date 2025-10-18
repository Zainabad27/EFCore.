namespace EFCore.Models
{
    public class Books
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
        public bool IsActive { get; set; } 
        public int NoOfPages { get; set; } 
        public string Description { get; set; } 



        //public int LanguageId { get; set; }
        //public Languages Languages { get; set; }
    }
}
