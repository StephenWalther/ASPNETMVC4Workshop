using EnterpriseApp.Service.Models;
using EnterpriseApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnterpriseApp.Presentation.Web.Controllers.API
{
    public class ProductsController : ApiController
    {
        private IProductsService _productsService;


        public ProductsController(IProductsService productsService) {
            _productsService = productsService;
        }



        public List<BriefProductDTO> GetProducts() {
            return _productsService.ListProducts(this.User).ToList();
        }

        public FullProductDTO Get(int id) {
            return _productsService.GetProduct(this.User, id);
        }

    }
}
