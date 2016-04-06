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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ReportServiceLib.Model.Product>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Product p = mapper.Map<Product, ReportServiceLib.Model.Product>(product);

            return service.AddProduct(p);

        }

        public bool DeleteProduct(Product product)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ReportServiceLib.Model.Product>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Product p = mapper.Map<Product, ReportServiceLib.Model.Product>(product);

            return service.DeleteProduct(p.Id);
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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ReportServiceLib.Model.Product>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Product p = mapper.Map<Product, ReportServiceLib.Model.Product>(product);

            return service.UpdateProduct(p);
        }
    }
}
