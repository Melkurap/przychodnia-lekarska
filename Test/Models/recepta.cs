using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class recepta
    {
        [Required]
        [Display(Name = "Id recepty")]
        public int receptaId { get; set; }

        [Required]
        [Display(Name = "Pacjent")]
        public string Pacjent { get; set; }

        [Required]
        [Display(Name = "Nazwa leku")]
        public string NazwaLeku { get; set; }

        [Required]
        [Display(Name = "Ilość opakowań oraz tabletek")]
        public string IloscOpakowanOrazTalbetek { get; set; }

        [Required]
        [Display(Name = "Ważność recepty")]
        public string WaznoscRecepty { get; set; }
    }
}