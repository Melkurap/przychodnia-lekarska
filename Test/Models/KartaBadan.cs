using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class KartaBadan
    {
        [Required]
        [Display(Name = "Id badania")]
        public int badanieId { get; set; }

        [Required]
        [Display(Name = "Pacjent")]
        public string Pacjent { get; set; }

        [Required]
        [Display(Name = "Typ wykonywanych badań")]
        public string TypWykonywanychBadan { get; set; }

        [Required]
        [Display(Name = "Nazwa badania")]
        public string NazwaBadania { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public string Cena { get; set; }

        [Required]
        [Display(Name = "Wybór")]
        public string Wybor { get; set; }

        [Required]
        [Display(Name = "Wyniki")]
        public string Wyniki { get; set; }
    }
}