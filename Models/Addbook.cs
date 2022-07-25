using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{

    public class Addbook
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       
        public string Subject { get; set; }

        
        public string Author { get; set; }

        
        public string Publisher { get; set; }


        
        public int Page { get; set; }

        
        public int Isbn { get; set; }

        
        public string Copies { get; set; }


        public string Libraryname { get; set; }

        
        public int Shelfno { get; set; }

       
        [DataType(DataType.Text)]
        public string Description { get; set; }


    }
}
