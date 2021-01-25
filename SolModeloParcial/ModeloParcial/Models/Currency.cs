namespace ModeloParcial.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Currency
    {
        [Key]
        public string code { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string symbol { get; set; }
    }
}