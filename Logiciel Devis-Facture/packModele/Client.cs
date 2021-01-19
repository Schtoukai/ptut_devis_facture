using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logiciel_Devis_Facture.packModele
{
    class Client
    {
        private int id;
        private String name;
        private String street;
        private String city;
        private String mail;
        private String phone;

        public Client() {}

        public Client(int id, String name, String street, String city, String mail, String phone)
        {
            this.id = id;
            this.name = name;
            this.street = street;
            this.city = city;
            this.mail = mail;
            this.phone = phone;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
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

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String getStreet()
        {
            return this.street;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public String getCity()
        {
            return this.city;
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
    }
}
