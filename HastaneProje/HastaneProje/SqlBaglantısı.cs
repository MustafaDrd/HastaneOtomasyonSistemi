using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneProje
{
    class SqlBaglantısı  // sınıfın adı
    {
        public SqlConnection baglanti()  // baglanti metodun adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-7FHN7H38;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open(); // nesne
            return baglan; 
        }
    }
}
