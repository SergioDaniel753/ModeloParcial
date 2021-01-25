namespace ModeloParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    public class Language
    {
        [Key]
        [Required]
        public string iso639_1 { get; set; }
        [Required]
        public string iso639_2 { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string nativeName { get; set; }
    }
}