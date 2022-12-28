using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Producer
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "ProfilePicture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = " Full Name")]
        public string FullName { get; set; }
        [Display(Name = " Bio")]
        public string Bio { get; set; }

        public List<Movies> Movies { get; set; }
    }
}
