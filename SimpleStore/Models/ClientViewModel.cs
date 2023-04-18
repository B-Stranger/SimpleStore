using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleStore.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public List<Order> ?Orders { get; set; }
        [DisplayName("Number Of Orders")]
        public int OrdersQuantity { get; set; }
        [DisplayName("Average Order's Price")]
        public decimal AvgOrderSum { get; set; }
    }
}
