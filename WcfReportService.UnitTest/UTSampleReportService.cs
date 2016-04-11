using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfReportService;
using WcfReportService.Model;

namespace WcfReportService.UnitTest
{
    /// <summary>
    /// UTSampleReportService 的摘要说明
    /// </summary>
    [TestClass]
    public class UTSampleReportService
    {
        private SampleReportService service;
        [TestInitialize]
        public void Intial()
        {
            service = new SampleReportService();
        }

        [TestMethod]
        public void TestGetSamples()
        {
            var result = service.GetSamples(0,10);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestAddUpdateDeleteSample()
        {
            Sample s = new Sample()
            {
                Id = Guid.NewGuid(),
                Material = "CIGS",
                Customer = "Midsummer",
                Lot = "160332-M-1",
                PO = "21323",
                Weight1 = "12",
                Weight2="45",
                Weight3="232",
                CreateDate=DateTime.Now
            };

            bool result1 = service.AddSample(s);
            Assert.IsTrue(result1);

            s.Customer = "xs.zhou";
            bool result2 = service.UpdateSample(s);
            Assert.IsTrue(result2);

            bool result3 = service.DeleteSample(s);
            Assert.IsTrue(result3);
        }

        [TestMethod]
        public void TestSampleCount()
        {
            int count = service.GetSampleCount();
            Assert.IsTrue(count >= 0);
        }


    }
}
