using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab1A.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Make{ get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Color { get; set; }
        public string DealershipID { get; set; }

    }
}
