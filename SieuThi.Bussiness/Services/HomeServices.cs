using SieuThi.Bussiness.Interfaces;
using SieuThi.Models.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThi.Bussiness.Services
{
    public class HomeServices : BaseServices, IHomeServices
    {
        public IEnumerable<MatHangListModel> MatHangListSelect()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(LocalConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from tblMatHang", conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            return dt.ToList<MatHangListModel>();
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
