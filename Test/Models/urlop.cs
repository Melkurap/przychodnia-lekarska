using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Test.Models
{
    public class urlop
    {
        [Required]
        [Display(Name = "Id urlopu")]
        public string UrlopId { get; set; }

        [Required]
        [Display(Name = "Lekarz")]
        public string Lekarz { get; set; }
        
        [Required]
        [Display(Name = "Data od")]
        public string DataOd { get; set; }

        [Required]
        [Display(Name = "Data do")]
        public string DataDo { get; set; }

        [Required]
        [Display(Name = "typ urlopu ")]
        public string typUrlopu { get; set; }

    }
}