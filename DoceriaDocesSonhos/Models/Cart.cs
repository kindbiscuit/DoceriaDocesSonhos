using DoceriaDocesSonhos.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DoceriaDocesSonhos.Models
{
    public class Cart
    {

        public Cart(int id, int idUser, Product product, int productQuantity)
        {
            Id = id;
            IdUser = idUser;
            Product = product;
            ProductQuantity = productQuantity;
            InclusionDate = DateTime.Now;
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime? InclusionDate { get; set; }
        public decimal Total { get 
            {
                return this.Product.Preco * this.ProductQuantity;
            } }
        public decimal GetTotal()
        {
            return Total;
        }
    }
}
