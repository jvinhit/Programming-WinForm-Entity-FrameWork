using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BALayer
{
    public class DThanhPho
    {
        private string maTP;
        public string MaThanhPho
        {
            get { return maTP; }
            set { maTP = value; }
        }
        private string tenTP;
        public string TenThanhPho
        {
            get { return tenTP; }
            set { tenTP = value; }
        }
        public DThanhPho()
        {
        }
        public DThanhPho(ThanhPho tp)
        {
            this.MaThanhPho = tp.MaThanhPho;
            this.TenThanhPho = tp.TenThanhPho;
        }
    }
}
