using System;
namespace EnterpriseApp.Service.Services {
    public interface IProductsService {
        EnterpriseApp.Service.Models.FullProductDTO GetProduct(System.Security.Principal.IPrincipal principal, int id);
        System.Collections.Generic.List<EnterpriseApp.Service.Models.BriefProductDTO> ListProducts(System.Security.Principal.IPrincipal principal);
    }
}
