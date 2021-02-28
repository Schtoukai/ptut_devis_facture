using System;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using MySql.Data.MySqlClient;

namespace Logiciel_Devis_Facture.packModele
{
    public class Client
    {
        private String id;
        private String name;
        private string[] address;
        private String mail;
        private String phone;
        private string connstring = @"server=localhost;user id=root;password=root"; // tant que la bd n'est pas crée on ne la précise pas
        private MySqlConnection connection;

        public Client() {}

        public Client(String id, String name, string[] address, String mail, String phone)
        {
           // string Querry = "SELECT * FROM";
            this.id = id;
            this.name = name;
            this.address = address;
            this.mail = mail;
            this.phone = phone;
            /*try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry + " customer;", connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                DataTable dt = ds.Tables["customer"];
                DataRow row = dt.Rows[0];
                this.id = row[0].ToString();
                this.name = row[1].ToString();
                address[0] = row[2].ToString();
                address[1] = row[3].ToString();
                address[2] = row[4].ToString();
                address[3] = row[5].ToString();
                mail = row[6].ToString();
                phone = row[7].ToString();
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }*/

        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getId()
        {
            return this.id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setAddress(String[] address)
        {
            this.address = address;
        }

        public String[] getAddress()
        {
            return this.address;
        }

        public String getAdress()
        {
            return this.address[0] + " " + this.address[1] + " " + this.address[2] + " " + this.address[3];
        }

        public void setMail(String mail)
        {
            this.mail = mail;
        }

        public String getMail()
        {
            return this.mail;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public String getPhone()
        {
            return this.phone;
        }

        public bool insertIntoCustomerTable(string id, string name, string address, string additional, string zip, string city, string mail, string phone)
        {
            string Querry = "INSERT INTO customer VALUES(" + '"' + id + '"' + "," + '"' + name + '"' + "," + '"' + address + '"' + "," + '"' + additional + '"' + "," + '"' + zip + '"' + "," + '"' + city + '"' + "," + '"' + mail + '"' + "," + '"' + phone + ");";
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

        /*                                                      *
        *             Fonction d'update Entreprise         * 
        *                                                      */
        public bool updateCustomerTable(string id, string name, string address, string additional, string zip, string city, string mail, string phone)
        {
            string Querry = "UPDATE customer SET nameCustomer = " + '"' + name + '"' + ", address = " + '"' + address + '"' + ", complement = " + '"' + additional + '"' + ", zipcode = " + '"' + zip + '"' + ", city = " + '"' + city + '"' + ", mail = " + '"' + mail + '"' + ", phone = " + '"' + phone + '"' + " WHERE idCustomer = " + "'" + id + "';";
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

        public bool deleteCustomerTable(string id)
        {
            string Querry = "DELETE FROM customer WHERE idCustomer = " + '"' + id + '"' + ";";
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

        public static DataTable selectCustomer(String request)
        {
            string connstring = @"server=localhost;user id=root;password=root"; // tant que la bd n'est pas crée on ne la précise pas
            MySqlConnection connection;
            string Querry = "USE invoicedatabase; SELECT * FROM customer WHERE LOWER(nameCustomer) LIKE " + "'%" + request + "%'" + " OR " + "LOWER(phone) LIKE " + "'%" + request + "%';";
            Console.WriteLine(Querry);
            connection = new MySqlConnection(connstring);
            try
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "customer");
                DataTable dt = ds.Tables["customer"];
                return dt;
            }
            catch (Exception c)
            {
                Console.WriteLine(c);
                return null;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
