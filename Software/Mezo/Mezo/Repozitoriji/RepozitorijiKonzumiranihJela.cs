using DBLayer;
using Mezo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezo.Repozitoriji
{
    internal class RepozitorijiKonzumiranihJela
    {
        public static KonzumiranaJela UcitajKonzumiranaJela(int Id_Jelo)
        {
            KonzumiranaJela konzumiranaJela = null;
            string sql = $"SELECT * FROM dbo.KonzumiranoJelo WHERE Id_Jelo = {Id_Jelo}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                konzumiranaJela = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return konzumiranaJela;
        }

        public static List<KonzumiranaJela> UcitajKonzumiranaJela()
        {
            List<KonzumiranaJela> konzumiranaJela = new List<KonzumiranaJela>();
            string sql = "SELECT * FROM dbo.KonzumiranoJelo";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                KonzumiranaJela konzumiranaJelo = CreateObject(reader);
                konzumiranaJela.Add(konzumiranaJelo);
            }
            reader.Close();
            DB.CloseConnection();
            return konzumiranaJela;
        }

        private static KonzumiranaJela CreateObject(SqlDataReader reader)
        {
            int idJelo = int.Parse(reader["Id_Jelo"].ToString());
            string glavnoJelo = reader["GlavnoJelo"].ToString();
            DateTime vrijemeNarudzbe = DateTime.Parse(reader["VrijemeNarudzbe"].ToString());
            DateTime vrijemeUrucivanja = DateTime.Parse(reader["VrijemeUrucivanja"].ToString());

            var konzumiranaJela = new KonzumiranaJela()
            {
                Id_Jelo = idJelo,
                GlavnoJelo = glavnoJelo,
                VrijemeNarudzbe = vrijemeNarudzbe,
                VrijemeUrucivanja = vrijemeUrucivanja
            };

            return konzumiranaJela;
        }
    }
}
