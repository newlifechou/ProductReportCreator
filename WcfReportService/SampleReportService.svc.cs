using ReportServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfReportService.Model;
using AutoMapper;

namespace WcfReportService
{
    public class SampleReportService : ISampleReportService
    {
        private SampleReport service;
        public SampleReportService()
        {
            service = new SampleReport();
        }

        public bool AddSample(Sample sample)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap< Sample, ReportServiceLib.Model.Sample>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Sample s = mapper.Map<Sample,ReportServiceLib.Model.Sample >(sample);

            return service.AddSample(s);
        }

        public bool DeleteSample(Sample sample)
        {
            return service.DeleteSample(sample.Id);
        }

        public int GetSampleCount()
        {
            return service.GetSampleCount();
        }

        public List<Sample> GetSamples(int skip, int take)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ReportServiceLib.Model.Sample, Sample>());
            var mapper = config.CreateMapper();

            List<Sample> samples = mapper.Map<List<ReportServiceLib.Model.Sample>, List<Sample>>(service.GetSamples(skip,take));

            return samples.ToList();
        }

        public bool UpdateSample(Sample sample)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Sample, ReportServiceLib.Model.Sample>());
            var mapper = config.CreateMapper();

            ReportServiceLib.Model.Sample s = mapper.Map<Sample, ReportServiceLib.Model.Sample>(sample);

            return service.UpdateSample(s);
        }
    }
}
