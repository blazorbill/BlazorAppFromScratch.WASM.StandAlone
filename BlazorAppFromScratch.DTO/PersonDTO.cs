using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.DTO
{
    public class PersonDTO
    {
        public int ID { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + (FirstName.Length > 0 ? " " : "") + LastName;
            }
        }
    }
}
