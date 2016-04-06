using ReportServiceLib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 10:52:03
*/
namespace ReportServiceLib
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("name=productsystem")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sample> Samples { get; set; }


    }
}
