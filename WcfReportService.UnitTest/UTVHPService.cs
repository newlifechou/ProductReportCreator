using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 16:15:42
*/
namespace WcfReportService.UnitTest
{
    [TestClass]
    public class UTVHPService
    {
        private VHPService service;
        [TestInitialize]
        public void Initial()
        {
            service = new VHPService();
        }

        [TestMethod]
        public void TestGetVHps()
        {
            int skip = 0;
            int take = 50;
            int count = service.GetVHPs(skip, take).Count;
            bool result = count>= 0&&count<=50;
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestVHPCount()
        {
            int count = service.GetVHPCount();
            Assert.IsTrue(count > 0);
        }


    }
}
