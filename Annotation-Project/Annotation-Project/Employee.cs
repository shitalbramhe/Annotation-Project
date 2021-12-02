using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
     class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and maximim 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18, 99, ErrorMessage = "Age Should be Above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
