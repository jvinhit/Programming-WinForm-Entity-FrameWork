using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BALayer
{
    public class LoadData
    {
        public void InitialData()
        {
            Data dt = new Data();
            dt.ThemDuLieu();
        }
    }
}
