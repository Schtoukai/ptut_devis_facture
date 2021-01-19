using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
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
        Company(){}

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

        Logo getCompLogo()
        {
            return compLogo;
        }

        string getSiret() 
        {
            return siret;
        }

        string getStreet() {
            return street;
        }

        string getCity() {
            return city;
        }

        string getMail() {
            return mail;
        }

        string getPhone() {
            return phone;
        }

        object searchInvoice(int numero)
        {
            for (int i = 0; i < listInvoice.Count; i++){
                if (listInvoice[i].getNumero() == numero)
                    return listInvoice[i];
            }
            return false;
        }

        bool addInvoice(PDF invoice)
        {
            listInvoice.Add(invoice);
            return true;
        }
    }
}
