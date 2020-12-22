using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sql刪除
{
    public static class cn1
    {
        public static SqlConnection cn
        {
            get
            {
                return new SqlConnection("Data Source=.;Initial Catalog=Disneyland_Shanghai_ANO;Integrated Security=True");
            }
        }
    }
}
