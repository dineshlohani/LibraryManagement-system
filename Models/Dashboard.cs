using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    
    public class Dashboard
    { 
     

        [Key]

        public string Id { get; set; }
       
        [Required]
        public string Appid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        
        [Required]
        public int Number { get; set; }
        [Required]
        public string Birth { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }
        [Required]
        public string Course { get; set; }

        [Required]
        public string Gender { get; set; }

    

    }
}
  