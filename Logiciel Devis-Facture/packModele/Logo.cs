using System;
using System.Collections.Generic;
using System.Text;

namespace Logiciel_Devis_Facture.packModele
{
    class Logo
    {
        private string name;
        private string format;
        private int height;
        private int width;
        private string pathing;

        Logo()
        {
            ;
        }
        Logo(string _name,string _format, int _height, int _width, string _pathing)
        {
            name = _name;
            format = _format;
            height = _height;
            width = _width;
            pathing = _pathing;
        }
        string getName()
        {
            return name;
        }
        string getFormat()
        {
            return format;
        }
        string getPathing()
        {
            return pathing;
        }
        int getHeight()
        {
            return height;
        }
        int getWidth()
        {
            return width;
        }

        internal void setName(string v)
        {
            throw new NotImplementedException();
        }

        internal void setFormat(string v)
        {
            throw new NotImplementedException();
        }

        internal void setHeight(int v)
        {
            throw new NotImplementedException();
        }

        internal void setWidht(int v)
        {
            throw new NotImplementedException();
        }

        internal void setPathing(string v)
        {
            throw new NotImplementedException();
        }
    }
}
