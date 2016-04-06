using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public  interface IVHPReport
    {
        List<VHP> GetVHPs(int skip,int take);
        int VHPCount();
    }
}
