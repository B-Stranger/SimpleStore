using System.ComponentModel;

namespace SimpleStore.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [DisplayName("Client")]
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        [DisplayName("Order's Total Price")]
        public decimal TotalOrderValue { get; set; }
        [DisplayName("Product")]
        public string ProductTitle { get; set; }

    }
}
