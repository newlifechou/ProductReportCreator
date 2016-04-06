using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
