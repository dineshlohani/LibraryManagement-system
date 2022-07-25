using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    
    public class Dashboard
    { 
     

        [Key]

        public string Id { get; set; }
       
        [Required]
        public string Appid { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public EmailAddressAttribute Email { get; set; }

      
        public int Number { get; set; }

        public string Birth { get; set; }

        
        public string Address { get; set; }
       
        public string City { get; set; }
        
        public string State { get; set; }

        
        public int Zip { get; set; }

        public string Course { get; set; }


        public string Gender { get; set; }

        [NotMapped]
        public string Image { get; set; }

        [NotMapped]
        public string Signature { get; set; }





    }
}
  