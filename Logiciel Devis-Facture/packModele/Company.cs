﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;


namespace Logiciel_Devis_Facture.packModele
{
    class Company
    {
        private string siret;
        private string[] address = new string[4];
        private string mail;
        private string phone;
        private string nameCompany;
        private string website;
        private Logo compLogo;
        private List<PDF> listPDF = new List<PDF>();
        private List<Client> listClient = new List<Client>();
        private string connstring = @"server=localhost;user id=root;password=root;database=invoiceDatabase"; // tant que la bd n'est pas crée on ne la précise pas
        private MySqlConnection connection;
        private List<Materials> listMaterials = new List<Materials>();

        public Company()
        {
            string Querry = "SELECT * FROM";
            setCompLogo();
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
                nameCompany = row[1].ToString();
                address[0] = row[2].ToString();
                address[1] = row[3].ToString();
                address[2] = row[4].ToString();
                address[3] = row[5].ToString();
                mail = row[6].ToString();
                phone = row[7].ToString();
                website = row[8].ToString();
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

        Company(string siret, string street, string city, string mail, string phone, Logo compLogo, List<PDF> listPDF)
        {
            this.siret = siret;
            this.mail = mail;
            this.phone = phone;
            this.compLogo = compLogo;
            this.listPDF = listPDF;
        }

        public Logo getCompLogo()
        {
            return compLogo;
        }

        public void setCompLogo()
        {
            compLogo = new Logo();
        }

        public string getCompanyName()
        {
            return nameCompany;
        }

        public string getSiret() 
        {
            return siret;
        }

        public string getStreet() {
            return address[0];
        }

        public string getAdditionnal()
        {
            return address[1];
        }

        public string getZip()
        {
            return address[2];
        }

        public string getCity() {
            return address[3];
        }

        public string getMail() {
            return mail;
        }

        public string getPhone() {
            return phone;
        }

        public string getWebsite()
        {
            return website;
        }

        public List<Materials> getListMaterials()
        {
            return listMaterials;
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
        *             Fonction d'insert Entreprise         * 
        *                                                      */

        public bool insertIntoCompanyTable(string siret, string name, string address, string additional, string zip, string city, string mail, string phone, string website, string logo)
        {
            string Querry = "INSERT INTO company VALUES(" + '"' +  siret + '"' + "," + '"' + name + '"' + "," + '"' + address + '"' + "," + '"' + additional + '"' + "," + '"' + zip + '"' + "," + '"' + city + '"' + "," + '"' + mail + '"' + "," + '"' + phone + '"' + "," + '"' + website + '"' + "," + '"' + logo + '"' + ");";
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
        *             Fonction d'update Entreprise              * 
        *                                                      */
        public bool updateCompanyTable(string siret, string name, string address, string additional, string zip, string city, string mail, string phone, string website, string logo)
        {
            string Querry = "UPDATE company SET nameCompany = " + '"' + name + '"' + ", address = " + '"' + address + '"' + ", complement = " + '"' + additional + '"' + ", zipcode = " + '"' + zip + '"' + ", city = " + '"' + city + '"' + ", mail = " + '"' + mail + '"' + ", phone = " + '"' + phone + '"' + ", website = " + '"' + website + '"' + ", compLogo = " + '"' + logo + '"' + " WHERE siret = " + "'" + siret + "';";
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

        public bool deleteCompanyTable(string siret)
        {
            string Querry = "DELETE FROM Company WHERE siret = " + '"' + siret + '"' + ";";
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
                Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }



        /*                                                      *
         *             Fonction de recherche de client         * 
         *                                                      */
        public bool querryClient()
        {
            string Querry = "SELECT * FROM customer LIMIT 5;";
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
                    string[] b = new string[4];
                    b[0] = row[2].ToString();
                    b[1] = row[3].ToString();
                    b[2] = row[4].ToString();
                    b[3] = row[5].ToString();
                    Client a = new Client(int.Parse(row[0].ToString()), row[1].ToString(), b, row[6].ToString(), row[7].ToString());
                    listClient.Add(a);
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return true;
        }
        public bool querryClient(string toQuerry)
        {
            string Querry = "SELECT * FROM customer";
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
                    string[] b = new string[4];
                    b[0] = row[2].ToString();
                    b[1] = row[3].ToString();
                    b[2] = row[4].ToString();
                    b[3] = row[5].ToString();
                    Client a = new Client(int.Parse(row[0].ToString()), row[1].ToString(), b, row[6].ToString(), row[7].ToString());
                    listClient.Add(a);
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return true;
        }

        /*                                                      *
        *             Fonction de recherche de Materiaux       * 
        *                                                       */
        public bool querryMaterials()
        {
            string Querry = "SELECT idMaterials, nameMaterials, price, taux FROM materials join legislation on idLegislation=typeLegislation LIMIT 5;";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "materials");
                DataTable dt = ds.Tables["materials"];
                listMaterials.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Materials a = new Materials(int.Parse(row[0].ToString()), row[1].ToString(), float.Parse(row[2].ToString()), float.Parse(row[3].ToString()));
                    listMaterials.Add(a);
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return true;
        }
        public bool querryMaterials(string toQuerry)
        {
            string Querry = "SELECT idMaterials, nameMaterials, price, taux FROM materials join legislation on idLegislation=typeLegislation";
            if (toQuerry != "")
            {
                if (toQuerry[0] > 'A' && toQuerry[0] < 'Z')
                    toQuerry += "%;";
                if (toQuerry[0] > 'a' && toQuerry[0] < 'z')
                    toQuerry = "%" + toQuerry + "%;";
                else
                    return false;
                Querry += " Where nameMaterials LIKE" + toQuerry;
            }
            else
                Querry += " LIMIT 5;";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "materials");
                DataTable dt = ds.Tables["materials"];
                listMaterials.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Materials a = new Materials(int.Parse(row[0].ToString()), row[1].ToString(), float.Parse(row[2].ToString()), float.Parse(row[3].ToString()));
                    listMaterials.Add(a);
                }
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return true;
        }

        /*                                                      *
        *           Fonction pour le numéro du PDF              * 
        *                                                       */
        public int querryNumero()
        {
            string Querry = "SELECT max(idInvoice) FROM invoice;";
            try
            {
                connection = new MySqlConnection(connstring);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Querry, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "invoice");
                DataTable dt = ds.Tables["invoice"];
                int a = -1;
                foreach (DataRow row in dt.Rows)
                {
                    a = int.Parse(row[0].ToString());
                }
                return a;
            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                return -1;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
