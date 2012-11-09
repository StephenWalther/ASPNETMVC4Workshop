using EnterpriseApp.Service.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseApp.Presentation.Web.Infrastructure {
    public class DIBindings:NinjectModule {
        public override void Load() {
            this.Bind<IProductsService>().To<ProductsService>();
            
        }
    }
}