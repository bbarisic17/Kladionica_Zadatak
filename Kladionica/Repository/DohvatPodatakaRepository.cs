using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Model;
using System.Data.SqlClient;
using Kladionica.Services;

namespace Kladionica.Repository
{
    public class DohvatPodatakaRepository
    {
        public Novcanik DohvatiNovcanik()
        {
            Novcanik novcanik = new Novcanik();
            SqlDataReader reader = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
                if (!String.IsNullOrWhiteSpace(connectionString))
                {
                    string sqlDohvatiNovcanik = "SELECT [ID], [Iznos] from dbo.Novcanik";
                    conn = new System.Data.SqlClient.SqlConnection(connectionString);
                    conn.Open();

                    cmd = new System.Data.SqlClient.SqlCommand(sqlDohvatiNovcanik);
                    cmd.Connection = conn;
                    reader = cmd.ExecuteReader();
                    if (reader.FieldCount == 2)
                    {
                        while (reader.Read())
                        {
                            novcanik.Id = uint.Parse(reader["ID"].ToString());
                            novcanik.TrenutniIznos = decimal.Parse(reader["Iznos"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception)
            {
                throw;
            }            
            return novcanik;
        }
        public List<Par> DohvatiParove()
        {
            List<Par> parovi = new List<Par>();
            SqlDataReader reader = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
                string sqlDohvatiParove = "SELECT [ID], [Domacin], [Gost], [VrstaSporta], [KvotaPobjedaDomacina], [KvotaPobjedaGosta], [KvotaNerijeseno] from dbo.Par";
                conn = new System.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();

                cmd = new System.Data.SqlClient.SqlCommand(sqlDohvatiParove);
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Par par = new Par();
                    par.Id = uint.Parse(reader["ID"].ToString());
                    par.Domacin = reader["Domacin"].ToString();
                    par.Gost = reader["Gost"].ToString();
                    par.VrstaSporta = (Enumerations.VrstaSporta)int.Parse(reader["VrstaSporta"].ToString());
                    par.KvotaPobjedaDomacina = decimal.Parse(reader["KvotaPobjedaDomacina"].ToString());
                    par.KvotaPobjedaGosta = decimal.Parse(reader["KvotaPobjedaGosta"].ToString());
                    par.KvotaNerijeseno = decimal.Parse(reader["KvotaNerijeseno"].ToString());
                    parovi.Add(par);
                }
            }
            catch(Exception)
            {
                throw;
            }            
            return parovi;
        }
        public List<Listic> DohvatiListice()
        {
            List<Listic> listici = new List<Listic>();
            SqlDataReader reader = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
                string sqlDohvatiListice = @"SELECT dbo.Listic.[ID] as LID, dbo.Listic.[Sifra] as LSifra, dbo.Listic.[UplaceniIznos] as LUplaceniIznos, dbo.Listic.[UkupnaKvota] as LUkupnaKvota, 
                    dbo.Listic.[UkupniDobitak] as LUkupniDobitak, dbo.Listic.[ProvjereniRezultati] as ProvjereniRezultati, dbo.Listic.[Dobitak] as Dobitak, dbo.Par.ID as PID, dbo.Par.Domacin as PDomacin,
                    dbo.Par.Gost as PGost, dbo.Par.VrstaSporta as PVrstaSporta, dbo.Par.KvotaPobjedaDomacina as PKvotaPobjedaDomacina, dbo.Par.KvotaPobjedaGosta as PKvotaPobjedaGosta, dbo.Par.KvotaNerijeseno as PKvotaNerijeseno,
                    dbo.Listic_Par.Izbor1, dbo.Listic_Par.IzborX, dbo.Listic_Par.Izbor2, dbo.Listic_Par.BrojGolovaDomaci, dbo.Listic_Par.BrojGolovaGosti
                    from dbo.Listic inner join dbo.Listic_Par on dbo.Listic.ID = dbo.Listic_Par.ListicID
                    inner join dbo.Par on dbo.Par.ID = dbo.Listic_Par.ParID";
                conn = new System.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();

                cmd = new System.Data.SqlClient.SqlCommand(sqlDohvatiListice);
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    uint tempId = uint.Parse(reader["LID"].ToString());
                    if (tempId != 0)
                    {
                        bool postoji = listici.FirstOrDefault(item => item.Id == tempId) != null;
                        if (!postoji)
                        {
                            Listic listic = new Listic();
                            listic.Id = uint.Parse(reader["LID"].ToString());
                            listic.Sifra = reader["LSifra"].ToString();
                            listic.UplaceniIznos = decimal.Parse(reader["LUplaceniIznos"].ToString());
                            listic.UkupnaKvotaListica = decimal.Parse(reader["LUkupnaKvota"].ToString());
                            listic.UkupniDobitakListica = decimal.Parse(reader["LUkupniDobitak"].ToString());
                            listic.ProvjereniRezultati = bool.Parse(reader["ProvjereniRezultati"].ToString());
                            listic.Dobitak = bool.Parse(reader["Dobitak"].ToString());

                            Par par = new Par();
                            par.Id = uint.Parse(reader["PID"].ToString());
                            par.Domacin = reader["PDomacin"].ToString();
                            par.Gost = reader["PGost"].ToString();
                            par.VrstaSporta = (Enumerations.VrstaSporta)int.Parse(reader["PVrstaSporta"].ToString());
                            par.KvotaPobjedaDomacina = decimal.Parse(reader["PKvotaPobjedaDomacina"].ToString());
                            par.KvotaPobjedaGosta = decimal.Parse(reader["PKvotaPobjedaGosta"].ToString());
                            par.KvotaNerijeseno = decimal.Parse(reader["PKvotaNerijeseno"].ToString());
                            par.IzborPobjedaDomacina = bool.Parse(reader["Izbor1"].ToString());
                            par.IzborNerijeseno = bool.Parse(reader["IzborX"].ToString());
                            par.IzborPobjedaGosta = bool.Parse(reader["Izbor2"].ToString());
                            if (reader["BrojGolovaDomaci"] != DBNull.Value)
                                par.BrojGolovaDomaci = int.Parse(reader["BrojGolovaDomaci"].ToString());
                            if (reader["BrojGolovaGosti"] != DBNull.Value)
                                par.BrojGolovaGosti = int.Parse(reader["BrojGolovaGosti"].ToString());

                            if (listic.ParoviNaListicu.FirstOrDefault(item => item.Id == par.Id) == null)
                                listic.ParoviNaListicu.Add(par);
                            listici.Add(listic);
                        }
                        else
                        {
                            var listicTemp = listici.FirstOrDefault(item => item.Id == tempId);
                            if (listicTemp != null)
                            {
                                Par par = new Par();
                                par.Id = uint.Parse(reader["PID"].ToString());
                                par.Domacin = reader["PDomacin"].ToString();
                                par.Gost = reader["PGost"].ToString();
                                par.VrstaSporta = (Enumerations.VrstaSporta)int.Parse(reader["PVrstaSporta"].ToString());
                                par.KvotaPobjedaDomacina = decimal.Parse(reader["PKvotaPobjedaDomacina"].ToString());
                                par.KvotaPobjedaGosta = decimal.Parse(reader["PKvotaPobjedaGosta"].ToString());
                                par.KvotaNerijeseno = decimal.Parse(reader["PKvotaNerijeseno"].ToString());
                                par.IzborPobjedaDomacina = bool.Parse(reader["Izbor1"].ToString());
                                par.IzborNerijeseno = bool.Parse(reader["IzborX"].ToString());
                                par.IzborPobjedaGosta = bool.Parse(reader["Izbor2"].ToString());
                                if (reader["BrojGolovaDomaci"] != DBNull.Value)
                                    par.BrojGolovaDomaci = int.Parse(reader["BrojGolovaDomaci"].ToString());
                                if (reader["BrojGolovaGosti"] != DBNull.Value)
                                    par.BrojGolovaGosti = int.Parse(reader["BrojGolovaGosti"].ToString());

                                if (listicTemp.ParoviNaListicu.FirstOrDefault(item => item.Id == par.Id) == null)
                                    listicTemp.ParoviNaListicu.Add(par);
                            }
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return listici;
        }        
    }
}
