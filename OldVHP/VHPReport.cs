using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 15:45:51
*/
namespace OldVHP
{
    public class VHPReport : IVHPReport
    {
        public List<VHP> GetVHPs(int skip,int take)
        {
            DBNew db = new DBNew();
            List<VHP> vhps = new List<VHP>();
            var query = from o in db.tb_Order
                        join p in db.tb_Plan
                        on o.OrderID equals p.OrderID
                        orderby p.VHPTimePlan descending
                        select new VHP()
                        {
                            Id = Guid.NewGuid(),
                            VHPDate = p.VHPTimePlan,
                            VHPDevice = p.DeviceType,
                            Customer = o.Customer,
                            PO = o.PO,
                            ProductName=o.ProductName,
                            PMIWorkingNumber=o.PMIWorkNumber,
                            Dimension=o.Dimension
                        };
            return query.Skip(skip).Take(take).ToList(); 
        }
    }
}
