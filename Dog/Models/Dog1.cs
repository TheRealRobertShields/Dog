using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dog.Models
{
    public class Dog1
    {
        [Required(ErrorMessage = "Dog's Name required")]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Dog's Breed required")]
        public string Breed { get; set; }
    }
}
