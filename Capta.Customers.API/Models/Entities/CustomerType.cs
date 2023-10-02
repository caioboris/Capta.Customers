using System.ComponentModel.DataAnnotations;

namespace Capta.Customers.API.Models.Entities
{
    public class CustomerType
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Type { get; set; } = string.Empty;
    }
}