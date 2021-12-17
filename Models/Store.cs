using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thefashionproject.Models
{
    [Table("Store")]
    public class Store
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int BrandID { get; set; }

        [Required(ErrorMessage = "Please enter the name of your Brand"), MaxLength(30)]
        [Display(Name = "Luis Feathered")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Please enter your name."), MaxLength(100)]
        [Display(Name = "e.g.luis feathered...")]
        public string OwnersName { get; set; }

        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "Please upload a photo of your ")]
        public string IDPhoto { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your Contact number."), MaxLength(30)]
        [Display(Name = "e.g.0730461...")]
        public string ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "luis feathered")]
        public string Email_Address { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You really need a password")]
        [Display(Name = "*******")]
        public string password { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter your physical address")]
        [Display(Name = "e.g.D999 Mbiza Drive...")]
        public string Office_Address { get; set; }

    }
}
