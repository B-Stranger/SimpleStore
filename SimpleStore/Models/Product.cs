using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        [DisplayName("Product's Title")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
