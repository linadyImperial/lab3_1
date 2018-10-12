using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab1A.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstNAme { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Company { get; set; }
        public string Position { get; set; }
        public string BirthDate { get; set; }

    }
}
