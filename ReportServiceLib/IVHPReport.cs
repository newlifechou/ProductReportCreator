using ReportServiceLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportServiceLib
{
   public  interface IVHPReport
    {
        List<VHP> GetVHPs();
    }
}
