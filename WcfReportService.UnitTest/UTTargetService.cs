using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfReportService;
using WcfReportService.Model;

namespace WcfReportService.UnitTest
{
    [TestClass]
    public class UTTargetService
    {
        private TargetReportService service;

        [TestInitialize]
        public void Initial()
        {
            service = new TargetReportService();
        }

        [TestMethod]
        public void TestGetTargets()
        {
            var targets=service.GetTargets();

            Assert.IsNotNull(targets);
        }

        [TestMethod]
        public void TestAddUpdateDeleteTarget()
        {
            Target p = new Target()
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

            bool result1 = service.AddTarget(p);
            Assert.IsTrue(result1);

            p.Customer = "xs.zhou";
            bool result2 = service.UpdateTarget(p);

            Assert.IsTrue(result2);

            bool result3=service.DeleteTarget(p);
            Assert.IsTrue(result3);
        }


    }
}
