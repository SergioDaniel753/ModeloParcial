using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ModeloParcial.Models
{
    public class RegionalBloc
    {
        [Key]
        public string acronym { get; set; }
        [Required]
        public string name { get; set; }
        public List<string> otherAcronyms { get; set; }
        public List<string> otherNames { get; set; }
    }
}