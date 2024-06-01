using DBLayer;
using Mezo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mezo.Repozitoriji
{
    public class RepozitorijiRecenzija
    {
        public static List<Recenzija> GetRecenzija()
        {
            
            var recenzije = new List<Recenzija>();
            
            string sql = "SELECT * FROM dbo.Recenzija";
            
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql); 
            while (reader.Read())
            {
                Recenzija recenzija = CreateObject(reader);
                recenzije.Add(recenzija);
            }

            reader.Close();
            DB.CloseConnection();

            return recenzije;
        }

        public static List<Recenzija> SearchRecenzije(string pretrazivanje)
        {
            var recenzije = new List<Recenzija>();

            string sql = $"SELECT * FROM Recenzija WHERE OcjenaOkusa LIKE '%{pretrazivanje}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Recenzija recenzija = CreateObject(reader);
                recenzije.Add(recenzija);
            }

            reader.Close();
            DB.CloseConnection();

            return recenzije;
        }

        private static Recenzija CreateObject(SqlDataReader reader)
        {
            int idRecenzija = int.Parse(reader["Id_Recenzija"].ToString());
            DateTime datumRecenzije = DateTime.Parse(reader["DatumRecenzije"].ToString());
            int idJelo = int.Parse(reader["Id_Jelo"].ToString());
            int ocjenaOkusa = int.Parse(reader["OcjenaOkusa"].ToString());
            int ocjenaKolicina = int.Parse(reader["OcjenaKolicina"].ToString());
            string komentar = reader["Komentar"].ToString();
            var recenzija = new Recenzija
            {
                Id_Recenzija = idRecenzija,
                DatumRecenzije = datumRecenzije,
                Id_Jelo = idJelo,
                OcjenaOkusa = ocjenaOkusa,
                OcjenaKolicina = ocjenaKolicina,
                Komentar = komentar
            };
            return recenzija;
        }
    }
}
