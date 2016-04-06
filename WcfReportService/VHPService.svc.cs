using ReportServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ReportServiceLib.Model;
using WcfReportService.Model;
using AutoMapper;

namespace WcfReportService
{
    public class VHPService : IVHPService
    {
        private Common.IVHPReport service;
        public VHPService()
        {

            service = new OldVHP.VHPReport();
        }
        public List<Model.VHP> GetVHPs(int skip, int take)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Common.Model.VHP,VHP>());
            var mapper = config.CreateMapper();

            Common.IVHPReport service = new OldVHP.VHPReport();
            List<VHP> results = mapper.Map<List<Common.Model.VHP>, List<VHP>>(service.GetVHPs(skip,take));
            return results;
        }

        public int VHPCount()
        {
            return service.VHPCount();
        }
    }
}
