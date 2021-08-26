using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThi.Bussiness.Services
{
    public class BaseServices
    {
        private static readonly string _LocalConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        protected string LocalConnectionString
        {
            get
            {
                return _LocalConnectionString;
            }
        }
    }
}
