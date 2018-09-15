using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Model;
using System.Data.SqlClient;
using System.Data.Common;

namespace Kladionica.Services
{
    public class SpremanjePodataka
    {
        public void SpremiStanjeNovcanika(Novcanik novcanik)
        {
            string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
            System.Data.SqlClient.SqlConnection sqlConnection =
     new System.Data.SqlClient.SqlConnection(connectionString.ToString());

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;            
            cmd.CommandText = "UPDATE Novcanik SET [Iznos] = @Iznos WHERE [ID] = @ID";
            cmd.Parameters.AddWithValue("@Iznos", novcanik.TrenutniIznos);
            cmd.Parameters.AddWithValue("@ID", int.Parse(novcanik.Id.ToString()));
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
           
        }
        public void SpremiOdigraniListic(Listic listic)
        {
            string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection(connectionString.ToString());

            string sqlSpremanjeListica = @"INSERT INTO Listic ([Sifra], [UplaceniIznos], [UkupnaKvota], [UkupniDobitak])
                                                VALUES (@Sifra, @UplaceniIznos, @UkupnaKvota, @UkupniDobitak) SELECT SCOPE_IDENTITY()";

            string sqlSpremanjeParovaNaListicu = @"INSERT INTO Listic_Par ([ListicID], [ParID]) VALUES (@ListicId, @ParID)";

            string sqlDohvatiZadnjuSifruListica = "SELECT TOP 1 Sifra from Listic order by ID desc";
            string sqlDohvatiBrojListica = "SELECT COUNT (*) FROM Listic";

            if (listic.Id == 0)
            {
                try
                {                    
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    SqlDataReader reader = null;
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = sqlDohvatiBrojListica;
                    var brojListica = cmd.ExecuteScalar();
                    if (brojListica == null)
                        return;

                    if (brojListica != null && int.Parse(brojListica.ToString()) == 0)
                    {
                        listic.Sifra = "00001";
                    }
                    else
                    {
                        cmd.CommandText = sqlDohvatiZadnjuSifruListica;
                        reader = cmd.ExecuteReader();
                        string zadnjaSifra = String.Empty;
                        while (reader.Read())
                        {
                            zadnjaSifra = reader["Sifra"].ToString();
                        }
                        if (!String.IsNullOrWhiteSpace(zadnjaSifra))
                        {
                            int zadnjaSifraTemp = int.Parse(zadnjaSifra.ToString());
                            if (zadnjaSifraTemp != 0)
                            {
                                zadnjaSifraTemp += 1;
                                listic.Sifra = zadnjaSifraTemp.ToString("D5");
                            }
                        }
                        else
                            return;
                        reader.Close();
                    }

                    cmd.CommandText = sqlSpremanjeListica;
                    cmd.Parameters.AddWithValue("@Sifra", listic.Sifra);
                    cmd.Parameters.AddWithValue("@UplaceniIznos", listic.UplaceniIznos);
                    cmd.Parameters.AddWithValue("@UkupnaKvota", listic.UkupnaKvotaListica);
                    cmd.Parameters.AddWithValue("@UkupniDobitak", listic.UkupniDobitakListica);
                    
                    var lastId = cmd.ExecuteScalar();
                    if (lastId != null)
                        listic.Id = uint.Parse(lastId.ToString());

                    if (listic.ParoviNaListicu != null && listic.ParoviNaListicu.Count > 0)
                    {
                        cmd.CommandText = sqlSpremanjeParovaNaListicu;
                        foreach (var par in listic.ParoviNaListicu)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ListicID", int.Parse(listic.Id.ToString()));
                            cmd.Parameters.AddWithValue("ParID", int.Parse(par.Id.ToString()));
                            cmd.ExecuteNonQuery();
                        }                        
                    }
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void UnosTestnihPodataka()
        {
            string connectionString = PodaciZaKonekciju.DohvatiPodatkeZaKonekciju();
            System.Data.SqlClient.SqlConnection sqlConnection =
                new System.Data.SqlClient.SqlConnection(connectionString.ToString());

            string sqlProvjeriPodatkeNovcanika = "SELECT COUNT (*) FROM Novcanik";
            string sqlProvjeriPodatkeParova = "SELECT COUNT (*) FROM Par";
            string sqlUnosPodatakaNovcanika = "INSERT INTO Novcanik ([Iznos]) VALUES (100)";
            string sqlUnosParova = @"INSERT INTO Par ([Domacin], [Gost], [VrstaSporta], [KvotaPobjedaDomacina], [KvotaPobjedaGosta], [KvotaNerijeseno])
                        VALUES ('Leicester', 'Liverpool', 1, 2.10, 1.50, 1.35),
                        ('Crystal Palace', 'Southempton', 1, 1.10, 2.70, 1.90),
                        ('Everton', 'Huddersfield', 1, 2.10, 1.50, 1.35),
                        ('Brighton', 'Fulham', 1, 1.80, 2.20, 1.35),
                        ('Chelsea', 'Bournemouth', 1, 1.10, 3.50, 2.35),
                        ('West Ham', 'Wolverhampton', 1, 1.60, 1.90, 1.65),
                        ('Man City', 'Newcastle', 1, 1.10, 2.50, 1.80)";

            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlProvjeriPodatkeNovcanika;
                var podaci = cmd.ExecuteScalar();
                if (podaci == null)
                    return;

                else if (podaci != null && int.Parse(podaci.ToString()) == 0)
                {
                    cmd.CommandText = sqlUnosPodatakaNovcanika;
                    cmd.ExecuteNonQuery();                    
                }

                cmd.CommandText = sqlProvjeriPodatkeParova;
                var brojParova = cmd.ExecuteScalar();
                if (brojParova == null)
                    return;
                else if (brojParova != null && int.Parse(brojParova.ToString()) == 0)
                {
                    cmd.CommandText = sqlUnosParova;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
