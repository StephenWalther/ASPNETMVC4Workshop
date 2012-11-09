using AutoMapper;
using EnterpriseApp.Domain.Services;
using EnterpriseApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseApp.Service.Services {
    public class ProductsService : IProductsService {

        private IProductsRepository _repository;

        public ProductsService(IProductsRepository productsRepository) {
            _repository = productsRepository;
        }

        // Convert Products to BriefProductDTOs
        public IList<BriefProductDTO> ListProducts(IPrincipal principal) {

            return Mapper.Map<IList<BriefProductDTO>>(_repository.ListProducts());

            //var domainProducts = _repository.ListProducts();
            //return (from p in domainProducts
            //    select new BriefProductDTO {Id=p.Id, Name=p.Name}).ToList();
        }



        // Convert Product to FullProductDTO
        public FullProductDTO GetProduct(IPrincipal principal, int id) {

            return Mapper.Map<FullProductDTO>(_repository.GetProduct(id));
            
            //var domainProduct = _repository.GetProduct(id);

            //return new FullProductDTO {
            //    Id = domainProduct.Id,
            //    Name = domainProduct.Name,
            //    Price = domainProduct.Price,
            //    Description = domainProduct.Description
            //};
        }
    
    }
}
