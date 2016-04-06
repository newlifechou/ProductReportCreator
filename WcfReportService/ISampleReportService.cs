using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfReportService.Model;

namespace WcfReportService
{
    [ServiceContract(Namespace ="http://www.newlifechou.com")]
    public interface ISampleReportService
    {
        [OperationContract]
        List<Sample> GetSamples();

        [OperationContract]
        bool AddSample(Sample sample);
        [OperationContract]
        bool UpdateSample(Sample sample);
        [OperationContract]
        bool DeleteSample(Sample sample);
    }
}
