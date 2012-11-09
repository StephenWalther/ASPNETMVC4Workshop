using EnterpriseApp.Domain.Models;
using EnterpriseApp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseApp.Persistence.NX {

    public class NXProductsRepository : IProductsRepository {
        public IQueryable<Domain.Models.Product> ListProducts() {
            // Get data from DB
            return (new List<Product> {
                new Product {Id=1, Name="Bread NX", Price=2.33m},
                new Product {Id=2, Name="Milk NX", Price=4.99m},
                new Product {Id=3, Name="Apples NX", Price=8.62m}
            }).AsQueryable();
        }

        public Domain.Models.Product GetProduct(int id) {
            // Get data from DB
            return new Product {
                Id = 2,
                Name = "Milk NX",
                Price = 4.99m
            };
        }

    }
}
