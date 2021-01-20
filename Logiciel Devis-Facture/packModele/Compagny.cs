using System;
using System.Collections.Generic;
using System.Text;
using Logo.cs;

namespace CreationDatabase
{
    class Compagny
    {
        private string siret;
        private string street;
        private string city;
        private string mail;
        private string phone;
        private Logo compLogo;
        private List<Invoice> listInvoice;
        private List<Quote> listQuote;
        Compagny()
        {
            ;
        }

        Compagny(string siret)
        {
            this.siret = siret;
        }

        Compagny(string siret,string street,string city,string mail,string phone, Logo compLogo)
        {
            this.siret = siret;
            this.street = street;
            this.city = city;
            this.mail = mail;
            this.phone = phone;
            this.compLogo = compLogo
        }

        Logo getCompLogo()
        {
            return compLogo;
        }
        string getSiret() 
        {
            return siret;
        };
        string getStreet() {
            return street;
        };
        string getCity() {
            return city;
        };
        string getMail() {
            return mail;
        };
        string getPhone() {
            return phone;
        };

        object searchInvoice(int numero)
        {
            for (int i = 0; i < listInvoice.Count(); int++){
                if(listInvoice[i].getNumero() == id )
                    return listInvoice[i]
            }
            for (int i = 0; i < listQuote.Count(); int++)
            {
                if (listQuote[i].getNumero() == id)
                    return listQuote[i]
            }
        }

        bool addInvoice(Invoice invoice)
        {
            listInvoice.Add(invoice);
        }
        bool addQuote(Quote quote)
        {
            listQuote.Add(quote);
        }
    }
}
