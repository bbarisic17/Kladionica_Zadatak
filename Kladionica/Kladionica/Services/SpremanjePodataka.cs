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
            System.Data.SqlClient.SqlConnection sqlConnection1 =
     new System.Data.SqlClient.SqlConnection(connectionString.ToString());

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "UPDATE Novcanik SET [Iznos] = 225 WHERE [ID] = 1";
            cmd.CommandText = "INSERT INTO Novcanik ([Iznos]) VALUES (1111)";
            /*cmd.Parameters.AddWithValue("@RegionDescription", "East");
            cmd.Parameters.AddWithValue("@RegionID", "1");*/
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            int affected =  cmd.ExecuteNonQuery();
            sqlConnection1.Close();
           
        }
    }
}
