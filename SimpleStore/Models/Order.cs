using System.ComponentModel.DataAnnotations;

namespace SimpleStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Client")]
        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
