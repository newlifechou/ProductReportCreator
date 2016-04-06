using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfReportService
{
    [ServiceContract(Namespace ="http://www.newlifechou.com")]
    public interface IProductReport
    {
        List<Product> GetProducts();


    }
}
