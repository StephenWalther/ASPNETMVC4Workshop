using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnterpriseApp.Presentation.Web.Controllers.API;
using Moq;
using EnterpriseApp.Service.Services;
using EnterpriseApp.Service.Models;
using System.Collections.Generic;
using System.Security.Principal;

namespace Presentation.Tests.Controllers.API {

    [TestClass]
    public class ProductsControllerTests {
    
        [TestMethod]
        public void TestGetProducts() {
            // Arrange
            var fakeData = new List<BriefProductDTO> {
                new BriefProductDTO {Id=1, Name="Product1"},
                new BriefProductDTO {Id=4, Name="Product2"},
                new BriefProductDTO {Id=5, Name="Product3"}
            };
            var mockService = new Mock<IProductsService>();
            mockService.Setup(s => s.ListProducts(It.IsAny<IPrincipal>())).Returns(fakeData);
            var controller = new ProductsController(mockService.Object);

            // Act
            var results = controller.GetProducts();

            // Assert
            Assert.AreEqual("Product1", results[0].Name);
        }

    }
}
