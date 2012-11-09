using AutoMapper;
using EnterpriseApp.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseApp.Presentation.Web.App_Start {
    public class AutoMapperConfig {

        public static void Start() {
            Mapper.Initialize(c => c.AddProfile<AutoMapperProfile>());
        }

    
    }
}