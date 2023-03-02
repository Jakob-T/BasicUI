using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;

namespace BasicUI
{
    public class SqliteDataAccess
    {
        public static List<Zaposlenici> LoadPeople()
        {
            
            var Userlist = new List<Zaposlenici>();

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Zaposlenici";
                SQLiteDataReader reader = cmd.ExecuteReader();
                


                while (reader.Read())
                {
                    Zaposlenici zaposlenici = new Zaposlenici(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    Userlist.Add(zaposlenici);
                    
                    
                }

            }

            return Userlist; 
        }

        public static void InsertPeople(int ID, string Ime, string Prezime, string Kontakt, string Odjel, string Zanimanje)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                
                SQLiteCommand SqliteCmd = new SQLiteCommand(connection);
                SqliteCmd.CommandText ="INSERT INTO [Zaposlenici](ID, Ime, Prezime, Kontakt, Odjel, Zanimanje) VALUES (@ID, @Ime, @Prezime, @Kontakt, @Odjel, @Zanimanje)";
                SqliteCmd.Parameters.AddWithValue("@ID", ID);
                SqliteCmd.Parameters.AddWithValue("@Ime", Ime);
                SqliteCmd.Parameters.AddWithValue("@Prezime", Prezime);
                SqliteCmd.Parameters.AddWithValue("@Kontakt", Kontakt);
                SqliteCmd.Parameters.AddWithValue("@Odjel", Odjel);
                SqliteCmd.Parameters.AddWithValue("@Zanimanje", Zanimanje);
                connection.Open();
                SqliteCmd.ExecuteNonQuery();
                connection.Close();
                
            }
        }

        



        private static string LoadConnectionString(string id= "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

