using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SimpleStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client? Client { get; set; } 
        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
