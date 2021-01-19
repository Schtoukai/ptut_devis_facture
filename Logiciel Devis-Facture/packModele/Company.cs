using System;
using System.Collections.Generic;
using System.Text;

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
        private List<PDF> listpdf;
        Company(){}

        Company(string siret)
        {
            this.siret = siret;
        }

        Company(string siret,string street,string city,string mail,string phone, Logo compLogo, List<PDF> listpdf)
        {
            this.siret = siret;
            this.street = street;
            this.city = city;
            this.mail = mail;
            this.phone = phone;
            this.compLogo = compLogo;
            this.listpdf = listpdf;
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

        object searchpdf(int numero)
        {
            for (int i = 0; i < listpdf.Count; i++){
                if (listpdf[i].getNumero() == numero)
                    return listpdf[i];
            }
            return false;
        }

        bool addpdf(PDF pdf)
        {
            listpdf.Add(pdf);
            return true;
        }
    }
}
