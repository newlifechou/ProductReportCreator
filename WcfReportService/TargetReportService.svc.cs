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
    
    public class TargetReportService : ITargetReportService
    {
        private ReportServiceLib.TargetReport   service;

        public TargetReportService()
        {
            service = new ReportServiceLib.TargetReport();
        }

        public bool AddTarget(Target target)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Target, ReportServiceLib.Model.Target>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Target p = mapper.Map<Target, ReportServiceLib.Model.Target>(target);

            return service.AddTarget(p);

        }

        public bool DeleteTarget(Target target)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Target, ReportServiceLib.Model.Target>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Target p = mapper.Map<Target, ReportServiceLib.Model.Target>(target);

            return service.DeleteTarget(p.Id);
        }

        public List<Target> GetTargets()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ReportServiceLib.Model.Target, Target>());
            var mapper = config.CreateMapper();
            List<Target> targets=mapper.Map<List<ReportServiceLib.Model.Target>,List< Target >> (service.GetTargets());

            return targets;
        }

        public bool UpdateTarget(Target target)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Target, ReportServiceLib.Model.Target>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Target p = mapper.Map<Target, ReportServiceLib.Model.Target>(target);

            return service.UpdateTarget(p);
        }
    }
}
