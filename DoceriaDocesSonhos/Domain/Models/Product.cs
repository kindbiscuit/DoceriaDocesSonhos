using DoceriaDocesSonhos.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoceriaDocesSonhos.Models
{
    public class Product
    {
       [Key]
        public Guid Id { get;}
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
     
        [Display(Name = "Descrição")]
        [StringLength(30, MinimumLength = 3)]
        public string Descricao { get; set; }
      
        [Display(Name = "Preço")]
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
      
        [Display(Name ="Quantidade disponível")]
        public int QuantidadeDisponivel { get; set; }
        [Display(Name ="Tipo de doce")]
        public EnumTipoDeDoce TipoDeDoce { get; set; }

    }
}
