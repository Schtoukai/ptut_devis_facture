using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logiciel_Devis_Facture.packModele
{
    public class Client
    {
        private int id;
        private String name;
        private string[] address;
        private String mail;
        private String phone;

        public Client() {}

        public Client(int id, String name, string[] address, String mail, String phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
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

        public void setAddress(String[] address)
        {
            this.address = address;
        }

        public String[] getAddress()
        {
            return this.address;
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
