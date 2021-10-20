using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class termin_wizyty
    {
        [Required]
        [Display(Name = "Id wizyty")]
        public int WizytaId { get; set; }

        [Required]
        [Display(Name = "Pacjent")]
        public int PacjentId { get; set; }

        [Required]
        [Display(Name = "Data wizyty")]
        public string DataWizyty { get; set; }

        [Required]
        [Display(Name = "Numer sali")]
        public string NumerSali { get; set; }

       
    }
}