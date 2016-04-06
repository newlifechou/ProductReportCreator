using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfReportService.Model;
using ReportServiceLib;
using AutoMapper;

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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ReportServiceLib.Model.Product, Product>());
            var mapper = config.CreateMapper();
            List<Product> products=mapper.Map<List<ReportServiceLib.Model.Product>,List< Product >> (service.GetProducts());

            return products;
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
