using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class zwolnienia_lekarskie
    {
        [Required]
        [Display(Name = "Id zwolnienia")]
        public string ZwolnienieId { get; set; }

        [Required]
        [Display(Name = "Pacjent")]
        public string Pacjent { get; set; }

        [Required]
        [Display(Name = "Przyczyna")]
        public string Przyczyna { get; set; }

        [Required]
        [Display(Name = "Okres")]
        public string Okres { get; set; }
    }
}