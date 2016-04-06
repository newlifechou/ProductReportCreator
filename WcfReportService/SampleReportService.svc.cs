using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfReportService.Model;

namespace WcfReportService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SampleReportService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SampleReportService.svc 或 SampleReportService.svc.cs，然后开始调试。
    public class SampleReportService : ISampleReportService
    {
        public bool AddSample(Sample sample)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSample(Sample sample)
        {
            throw new NotImplementedException();
        }

        public List<Sample> GetSamples()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSample(Sample sample)
        {
            throw new NotImplementedException();
        }
    }
}
