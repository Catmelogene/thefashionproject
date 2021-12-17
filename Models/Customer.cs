using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace thefashionproject.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int CustomerNo { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "luis feathered")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You really need a password")]
        [Display(Name = "*******")]
        public string password { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter your physical address")]
        [Display(Name = "e.g.D999 Mbiza Drive...")]
        public string PhysicalAddress { get; set; }

        
    }
}
