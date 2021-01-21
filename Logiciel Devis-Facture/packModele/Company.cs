using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;


namespace Logiciel_Devis_Facture.packModele
{
    class Company
    {
        private string siret;
        private string street;
        private string city;
        private string mail;
        private string phone;
        private Logo compLogo;
        private List<PDF> listInvoice;
        private List<Client> listClient = new List<Client>();
        private string connstring = @"server=localhost;user id=root;password=R@a[i?G++{iPynQ;database=invoiceDatabase"; // tant que la bd n'est pas crée on ne la précise pas
        public MySqlConnection connection;

        public Company() {
            string Querry = "SELECT * FROM";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry + " company;", connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "company");
                DataTable dt = ds.Tables["company"];
                DataRow row = dt.Rows[0];
                siret = row[0].ToString();
                street = row[1].ToString();
                city = row[2].ToString();
                mail = row[3].ToString();
                phone = row[4].ToString();
                Querry += row[5].ToString();
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

        Company(string siret)
        {
            this.siret = siret;
        }

        Company(string siret,string street,string city,string mail,string phone, Logo compLogo, List<PDF> listInvoice)
        {
            this.siret = siret;
            this.street = street;
            this.city = city;
            this.mail = mail;
            this.phone = phone;
            this.compLogo = compLogo;
            this.listInvoice = listInvoice;
        }

        public Logo getCompLogo()
        {
            return compLogo;
        }

        public string getSiret() 
        {
            return siret;
        }

        public string getStreet() {
            return street;
        }

        public string getCity() {
            return city;
        }

        public string getMail() {
            return mail;
        }

        public string getPhone() {
            return phone;
        }

        public List<Client> getListClient()
        {
            return listClient;
        }

        public void updateMySqlConnection()
        {
            connection = new MySqlConnection(connstring);
        }
        
        


        /*                                                      *
         *             Fonction de rechercher de client         * 
         *                                                      */
        public bool querryClient()
        {
            /*string Querry = "SELECT * FROM customer LIMIT 5;";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                DataTable dt = ds.Tables["customer"];
                listClient.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Client a = new Client(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                    listClient.Add(a);
                }
            }
            catch (Exception c)
            {
                System.Console.WriteLine("ok : "+c);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }*/
            return true;
        }
        public bool querryClient(string toQuerry)
        {
            /*string Querry = "SELECT * FROM customer";
            if (toQuerry != "")
            {
                if (toQuerry[0] >= 'A' && toQuerry[0] <= 'Z')
                    toQuerry += "%;";
                else
                {
                    if (toQuerry[0] >= 'a' && toQuerry[0] <= 'z')
                        toQuerry = "%" + toQuerry + "%;";
                    else
                        return false;
                }
                Querry += " Where nameCustomer LIKE" + toQuerry;
            }
            else
                Querry += " LIMIT 5;";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                DataTable dt = ds.Tables["customer"];
                listClient.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Client a = new Client( int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(),  row[4].ToString());
                    listClient.Add(a);
                }
            }
            catch (Exception c)
            {
                System.Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }*/
            return true;
        }
    }
}
