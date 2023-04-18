using System.ComponentModel.DataAnnotations;

namespace SimpleStore.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get;set; }

        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public List<Order> ?Orders { get; set; }

    }
}
