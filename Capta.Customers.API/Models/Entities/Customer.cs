using Capta.Customers.API.Models.Entities.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Capta.Customers.API.Models.Entities
{
    public class Customer
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(80, ErrorMessage = "O Nome deve conter até 80 caracteres")]
        [MinLength(3, ErrorMessage = "O Nome deve conter ao menos 3 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}", ErrorMessage = "Insira um CPF válido")]
        public string CPF { get; set; }

        [Required]
        public CustomerType Type { get; set; }

        [Required]
        public CustomerGender Gender { get; set; }

        [Required]
        public CustomerSituation Situation { get; set; }

    }
}
