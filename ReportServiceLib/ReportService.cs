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

        public bool AddProduct(Product product)
        {
            db.Products.Add(product);
            int result=db.SaveChanges();
            return result > 0;
        }

        public bool UpdateProduct(Product product)
        {
            Product tmp = db.Products.FirstOrDefault(p => p.Id == product.Id);
            //赋值
            CloneProduct(product, tmp);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteProduct(Guid id)
        {
            Product tmp = db.Products.Find(id);
            db.Products.Remove(tmp);

            int result = db.SaveChanges();
            return result > 0;
        }

        private void CloneProduct(Product source,Product destination)
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
            destination.Composition = source.Composition;
        }

    }
}
