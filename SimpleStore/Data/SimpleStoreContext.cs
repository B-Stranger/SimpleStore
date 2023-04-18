using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleStore.Models;

namespace SimpleStore.Data
{
    public class SimpleStoreContext : DbContext
    {
        public SimpleStoreContext(DbContextOptions<SimpleStoreContext> options)
            : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; } = default!;

        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<Order> Orders { get; set; } = default!;

        public IQueryable<OrderViewModel> OrderViewModels => Orders.Select(o => new OrderViewModel
        {
            Id = o.Id,
            ClientName = o.Client.Name,
            ProductTitle = o.Product.Title,
            Quantity = o.Quantity,
            Status = o.Status,
            TotalOrderValue = o.Quantity * o.Product.Price
        });

        public IQueryable<ClientViewModel> ClientViewModels => Clients
            .Select(cv => new ClientViewModel{
                Id = cv.Id,
                Name = cv.Name,
                Email = cv.Email,
                Birthdate = cv.Birthdate,
                Gender = cv.Gender,
                Orders = cv.Orders,
                OrdersQuantity = cv.Orders != null ? cv.Orders.Count() : 0,
                AvgOrderSum = cv.Orders != null && cv.Orders.Any() ? cv.Orders.Average(o => o.Product.Price * o.Quantity) : 0m,
        });

    }
}
