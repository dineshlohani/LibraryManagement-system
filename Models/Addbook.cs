using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Addbook
    {
        [key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
       [EmailAddress]
       public string Email { get; set; }


    }

    internal class keyAttribute : Attribute
    {
    }
}
