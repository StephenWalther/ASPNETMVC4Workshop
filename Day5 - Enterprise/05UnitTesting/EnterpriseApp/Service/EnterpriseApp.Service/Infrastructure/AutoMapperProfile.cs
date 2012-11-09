using AutoMapper;
using EnterpriseApp.Domain.Models;
using EnterpriseApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseApp.Service.Infrastructure {
    public class AutoMapperProfile: Profile {

        public override string ProfileName {
            get {
                return "ServiceProfile";
            }
        }


        protected override void Configure() {
            Mapper.CreateMap<Product, BriefProductDTO>();
            Mapper.CreateMap<Product, FullProductDTO>();
        }

    }
}
