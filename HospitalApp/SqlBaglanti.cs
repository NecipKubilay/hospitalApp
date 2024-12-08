using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S8ASSTC;Initial Catalog=Hastane;Integrated Security=True;");
            baglan.Open();
            return baglan;

        }
    }
}
