using DoceriaDocesSonhos.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DoceriaDocesSonhos.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        [DataType(DataType.DateTime, ErrorMessage ="Data em formato inválido")]
        public DateTime? InclusionDate { get; set; }
        private decimal Total { get 
            {
                return this.Product.Preco * this.ProductQuantity;
            } }
        public decimal GetTotal()
        {
            return Total;
        }
    }
}
