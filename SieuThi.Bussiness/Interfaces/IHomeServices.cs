using SieuThi.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThi.Bussiness.Interfaces
{
    public interface IHomeServices
    {
        IEnumerable<MatHangListModel> MatHangListSelect();
    }
}
