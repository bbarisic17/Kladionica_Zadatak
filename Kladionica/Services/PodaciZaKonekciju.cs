using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Kladionica.Services
{
    public static class PodaciZaKonekciju
    {
        public static string DohvatiPodatkeZaKonekciju()
        { 
            string connString = ConfigurationManager.ConnectionStrings["Kladionica.Properties.Settings.Kladionica_DBConnectionString"].ConnectionString;;
            return connString;
        }
    }
}
