using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Model;
using System.Data.SqlClient;
using System.Data.Common;
using Kladionica.Repository;

namespace Kladionica.Services
{
    public class SpremanjePodatakaService
    {
        public void SpremiStanjeNovcanika(Novcanik novcanik)
        {
            SpremanjePodatakaRepository spremanjePodataka = new SpremanjePodatakaRepository();
            spremanjePodataka.SpremiStanjeNovcanika(novcanik);                       
        }
        public void SpremiOdigraniListic(Listic listic)
        {
            SpremanjePodatakaRepository spremanjePodataka = new SpremanjePodatakaRepository();
            spremanjePodataka.SpremiOdigraniListic(listic);                                        
        }
        public void UnosTestnihPodataka()
        {
            SpremanjePodatakaRepository spremanjePodataka = new SpremanjePodatakaRepository();
            spremanjePodataka.UnosTestnihPodataka();            
        }
        public void SpremiRezultateUtakmica(List<Listic> listici)
        {
            SpremanjePodatakaRepository spremanjePodataka = new SpremanjePodatakaRepository();
            foreach (var listic in listici)
                spremanjePodataka.SpremiRezultateUtakmica(listic);            
        }
    }

}
