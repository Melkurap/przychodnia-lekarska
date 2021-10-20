using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class skierowanie
    {
        [Required]
        [Display(Name = "Id skierowania")]
        public int SkierowanieId { get; set; }

        [Required]
        [Display(Name = "Lekarz")]
        public string Lekarz { get; set; }

        [Required]
        [Display(Name = "Pacjent")]
        public string Pacjent { get; set; }

        [Required]
        [Display(Name = "Miejsce skierowania")]
        public string Gdzie { get; set; }

        [Required]
        [Display(Name = "Data wystawnienia")]
        public string DataWystawnienia { get; set; }

    }
}