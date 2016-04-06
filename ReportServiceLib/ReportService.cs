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
    public class ReportService
    {
        private ProductsContext db;
        public ReportService()
        {
            db = new ProductsContext();
        }
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
