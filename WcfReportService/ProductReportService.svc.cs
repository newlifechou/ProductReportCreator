using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfReportService.Model;
using ReportServiceLib;


namespace WcfReportService
{
    public class ProductReportService : IProductReportService
    {
        private ReportService   service;
        public ProductReportService()
        {
            service = new ReportService();
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return service.GetProducts();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
