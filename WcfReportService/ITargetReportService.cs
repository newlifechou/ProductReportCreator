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
    public interface ITargetReportService
    {
        [OperationContract]
        List<Target> GetTargets();

        [OperationContract]
        bool AddTarget(Target product);
        [OperationContract]
        bool UpdateTarget(Target product);
        [OperationContract]
        bool DeleteTarget(Target product);
    }
}
