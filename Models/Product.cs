using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thefashionproject.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter the name of your item"), MaxLength(30)]
        [Display(Name = "Men's tee")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "please select the size of your item"), MaxLength(100)]
        public Size ProductSize { get; set; }

        [DataType(DataType.Upload)]
        [Required(ErrorMessage = "Please upload a photo of your ")]
        public string IDPhoto { get; set; }

        [Required(ErrorMessage = "Please enter your Contact number."), MaxLength(30)]
        [Display(Name = "e.g.0730461...")]
        public int Quantity { get; set; }

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

        public enum Size
        {
            S,
            M,
            L,
            XL,
            XXL
        }

        public enum Category
        {
            T_shirt,
            Shirt,
            Pants,
            TrackPant,
            Hoodie,
            Shoes,
            Sneakers,
            Jersey,         
            Socks,

        }
    }
}
