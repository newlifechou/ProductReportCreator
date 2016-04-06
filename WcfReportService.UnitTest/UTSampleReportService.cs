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
            var result = service.GetSamples();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestAddUpdateDeleteSample()
        {
            Sample s = new Sample()
            {
                Id = Guid.NewGuid(),
                Composition = "CIGS",
                Customer = "Midsummer",
                Lot = "160332-M-1",
                PO = "21323",
                Weight1 = "12",
                Weight2="45",
                Weight3="232",
                IsSend=true,
                SendDate=DateTime.Now
            };

            bool result1 = service.AddSample(s);
            Assert.IsTrue(result1);

            s.Customer = "xs.zhou";
            bool result2 = service.UpdateSample(s);
            Assert.IsTrue(result2);

            bool result3 = service.DeleteSample(s);
            Assert.IsTrue(result3);
        }




    }
}
