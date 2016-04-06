using ReportServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ReportServiceLib.Model;
using WcfReportService.Model;

namespace WcfReportService
{
    public class VHPService : IVHPService
    {
        public List<Model.VHP> GetVHPs()
        {
            Common.IVHPReport service;
            throw new NotImplementedException();
        }
    }
}
