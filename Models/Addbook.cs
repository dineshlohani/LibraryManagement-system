using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Addbook
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Copyright { get; set; }
        [Required]
        public int Edition { get; set; }
        [Required]
        public int Page { get; set; }

        [Required]
        public int Isbn { get; set; }

        [Required]
        public string Copies { get; set; }

        [Required]
        public string Libraryname { get; set; }

        [Required]
        public int Shelfno { get; set; }

       
        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }
       
        
    }

    internal class keyAttribute : Attribute
    {
    }
}
