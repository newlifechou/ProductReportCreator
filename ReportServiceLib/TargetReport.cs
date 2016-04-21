using ReportServiceLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 11:09:24
*/
namespace ReportServiceLib
{
    public class TargetReport
    {
        private ProductsContext db;
        public TargetReport()
        {
            db = new ProductsContext();
        }

        public List<Target> GetTargets(int skip, int take)
        {
            return db.Products.OrderByDescending(t=>t.CreateDate).Skip(skip).Take(take).ToList();
        }

        public List<Target> GetTargets(string lot,string customer,int skip,int take)
        {
            return db.Products.Where(p => p.Lot.StartsWith(lot)&&p.Customer.Contains(customer))
                .OrderByDescending(p => p.CreateDate).Skip(skip).Take(take).ToList();
        }

        public int GetTargetCount(string lot,string customer)
        {
            return db.Products.Where(p => p.Lot.StartsWith(lot) && p.Customer.Contains(customer)).Count();
        }

        public bool AddTarget(Target target)
        {
            db.Products.Add(target);
            int result=db.SaveChanges();
            return result > 0;
        }

        public bool UpdateTarget(Target target)
        {
            Target tmp = db.Products.Find(target.Id);
            //赋值
            CloneProduct(target, tmp);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteTarget(Guid id)
        {
            Target tmp = db.Products.Find(id);
            db.Products.Remove(tmp);

            int result = db.SaveChanges();
            return result > 0;
        }

        private void CloneProduct(Target source,Target destination)
        {
            destination.Id = source.Id;
            destination.Material = source.Material;
            destination.PO = source.PO;
            destination.Lot = source.Lot;
            destination.Size = source.Size;
            destination.Customer = source.Customer;
            destination.Density = source.Density;
            destination.Weight = source.Weight;
            destination.Resistance = source.Resistance;
            destination.CreateDate = source.CreateDate;
            destination.Remark = source.Remark;
            destination.XRFComposition = source.XRFComposition;
            destination.Dimension = source.Dimension;
            destination.OrderDate = source.OrderDate;
            destination.MaterialAbbr = source.MaterialAbbr;
        }

    }
}
