using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Model;
using System.Data.SqlClient;
using System.Configuration;
using Kladionica.Services;
using Kladionica.Repository;

namespace Kladionica.Services
{
    public class DohvatPodataka
    {
        public Novcanik DohvatiNovcanik()
        {
            DohvatPodatakaRepository dohvatPodataka = new DohvatPodatakaRepository();
            Novcanik novcanik = dohvatPodataka.DohvatiNovcanik();
            
            return novcanik;
        }
        public List<Par> DohvatiParove()
        {
            List<Par> parovi;
            DohvatPodatakaRepository dohvatPodataka = new DohvatPodatakaRepository();
            parovi = dohvatPodataka.DohvatiParove();
                    
            return parovi;
        }
        public List<Listic> DohvatiListice()
        {
            List<Listic> listici;
            DohvatPodatakaRepository dohvatPodataka = new DohvatPodatakaRepository();
            listici = dohvatPodataka.DohvatiListice();                        
            
            return listici;
        }        
    }
}
