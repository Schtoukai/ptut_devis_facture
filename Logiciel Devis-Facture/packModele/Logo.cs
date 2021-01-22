using System;
using System.Collections.Generic;
using System.Text;

namespace Logiciel_Devis_Facture.packModele
{
    public class Logo
    {
        private string name;
        private string format;
        private string pathing;

        public Logo()
        {
            ;
        }
        Logo(string _name, string _format, string _pathing)
        {
            name = _name;
            format = _format;
            pathing = _pathing;
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