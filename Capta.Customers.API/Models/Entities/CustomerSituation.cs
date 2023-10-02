using System.ComponentModel.DataAnnotations;

namespace Capta.Customers.API.Models.Entities
{
    public class CustomerSituation
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Situation { get; set; } = string.Empty;

    }
}