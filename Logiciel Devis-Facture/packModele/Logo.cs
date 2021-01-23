using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logiciel_Devis_Facture.packModele
{
    public class Logo
    {
        private string name;
        private string format;
        private string pathing;
        private string connstring = @"server=localhost;user id=root;password=R@a[i?G++{iPynQ;database=invoiceDatabase"; // tant que la bd n'est pas crée on ne la précise pas
        private MySqlConnection connection;

        public Logo()
        {
            string Querry = "SELECT * FROM Logo";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "Logo");
                DataTable dt = ds.Tables["Logo"];
                DataRow row = dt.Rows[0];
                name = row[0].ToString();
                pathing = row[1].ToString();
                format = row[2].ToString();
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        Logo(string _name, string _format, string _pathing)
        {
            name = _name;
            format = _format;
            pathing = _pathing;
        }

        public bool insertIntoLogoTable(string name, string path, string format)
        {
            string Querry = "INSERT INTO Logo VALUES(" + '"' + name + '"' + "," + '"' + path + '"' + "," + '"' + format + '"' + ");";
            Console.WriteLine(Querry);
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlScript script = new MySqlScript(connection, Querry);
                script.Execute();
                return true;
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public bool updateLogoTable(string name, string path, string format)
        {
            string Querry = "UPDATE Logo SET logoPath = " + '"' + path + '"' + ", formatLogo = "  + '"' + format + '"' + " WHERE nameLogo = " + '"' + name + '"' + ";";
            Console.WriteLine("Format: " + ", formatLogo = " + +'"' + format + '"');
            Console.WriteLine(Querry);
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlScript script = new MySqlScript(connection, Querry);
                script.Execute();
                return true;
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public bool deleteLogoTable(string name)
        {
            string Querry = "DELETE FROM Logo WHERE nameLogo = " + '"' + name + '"' + ";";
            Console.WriteLine(Querry);
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlScript script = new MySqlScript(connection, Querry);
                script.Execute();
                return true;
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void setName(string a)
        {
            name = a;
        }
        public void setFormat(string a)
        {
            format = a;
        }
        public void setPathing(string a)
        {
            pathing = a;
        }
        public string getName()
        {
            return name;
        }
        public string getFormat()
        {
            return format;
        }
        public string getPathing()
        {
            return pathing;
        }
    }
}