using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThi.Models.Home
{
    public class MatHangListModel
    {
        public int PK_iMamathangID { get; set; }
        public int FK_iMaloaihangID { get; set; }
        public string sTenhang { get; set; }
        public decimal dGiaban { get; set; }
        public int iSoluong { get; set; }
        public string sDonvitinh { get; set; }
        public string sMavach { get; set; }
    }
}
