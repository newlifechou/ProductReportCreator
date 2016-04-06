using ReportServiceLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 13:35:19
*/
namespace ReportServiceLib
{
    public class SampleReport
    {
        private ProductsContext db;
        public SampleReport()
        {
            db = new ProductsContext();
        }
        public List<Sample> GetSamples()
        {
            return db.Samples.ToList();
        }

        public bool AddSample(Sample sample)
        {
            db.Samples.Add(sample);
            return db.SaveChanges()>0;
        }

        public bool UpdateSample(Sample sample)
        {
            Sample tmp = db.Samples.Find(sample.Id);
            CloneSample(sample, tmp);
            return db.SaveChanges() > 0;
        }

        public bool DeleteSample(Guid id)
        {
            Sample tmp = db.Samples.Find(id);
            db.Samples.Remove(tmp);
            return db.SaveChanges() > 0;
        }

        private void CloneSample(Sample source,Sample destination)
        {
            destination.Id = source.Id;
            destination.Composition = source.Composition;
            destination.Customer = source.Customer;
            destination.Lot = source.Lot;
            destination.PO = source.PO;
            destination.Weight1 = source.Weight1;
            destination.Weight2 = source.Weight2;
            destination.Weight3 = source.Weight3;
            destination.Weight4 = source.Weight4;
            destination.IsSend = source.IsSend;
            destination.SendDate = source.SendDate;

        }
    }
}
