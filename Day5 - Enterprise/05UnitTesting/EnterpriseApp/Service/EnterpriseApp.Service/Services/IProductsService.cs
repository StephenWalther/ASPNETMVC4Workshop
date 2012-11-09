using EnterpriseApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
namespace EnterpriseApp.Service.Services {
    public interface IProductsService {
        FullProductDTO GetProduct(IPrincipal principal, int id);
        IList<BriefProductDTO> ListProducts(IPrincipal principal);
    }
}
