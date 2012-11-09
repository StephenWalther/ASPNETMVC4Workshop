using EnterpriseApp.Domain.Services;
using EnterpriseApp.Persistence.EF;
using EnterpriseApp.Persistence.NX;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseApp.Service.Infrastructure {
    public class DIBindings:NinjectModule {
        public override void Load() {
            this.Bind<IProductsRepository>().To<EFProductsRepository>();
        }
    }
}
