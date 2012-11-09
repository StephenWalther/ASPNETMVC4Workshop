using EnterpriseApp.Domain.Models;
using System;
using System.Linq;

namespace EnterpriseApp.Domain.Services {

    public interface IProductsRepository {
        Product GetProduct(int id);
        IQueryable<Product> ListProducts();
    }

}
