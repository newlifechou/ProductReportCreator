using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfReportService.Model;

namespace WcfReportService
{
    [ServiceContract(Namespace ="http://www.newlifechou.com")]
    public interface IProductReportService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        bool AddProduct(Product product);
        [OperationContract]
        bool UpdateProduct(Product product);
        [OperationContract]
        bool DeleteProduct(Product product);
    }
}
