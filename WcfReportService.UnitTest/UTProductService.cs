using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfReportService;
using WcfReportService.Model;

namespace WcfReportService.UnitTest
{
    [TestClass]
    public class UTProductService
    {
        private ProductReportService service;

        [TestInitialize]
        public void Initial()
        {
            service = new ProductReportService();
        }

        [TestMethod]
        public void TestGetProducts()
        {
            var products=service.GetProducts();

            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void TestAddDeleteProduct()
        {
            Product p = new Product()
            {
                Id = Guid.NewGuid(),
                Material = "Te",
                Lot = "160331-M-1",
                Size = "124.5x6.5",
                Customer = "Praxair",
                PO = "27839",
                Density = "5.91",
                Weight = "439.2",
                Composition = "",
                Resistance = "0.2",
                IsSend = true,
                SendDate = new DateTime(2016, 3, 8)
            };

            bool result1 = service.AddProduct(p);
            Assert.IsTrue(result1);
            bool result2=service.DeleteProduct(p);
            Assert.IsTrue(result2);
        }
        [TestMethod]
        public void TestUpdateProduct()
        {

        }


    }
}
