using System;
using System.Collections.Generic;
using System.Text;

namespace CreationDatabase
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

        void setName(string a) {
            name = a;
        };
        void setFormat(string a){
            format = a;
        };
        void setPathing(string a) {
            pathing = a;
        }
        void setWidth(int a) {
            width = a;
        };
        void setHeight(int a){
            height = a;
        };

        string getName()
        {
            return name;
        };
        string getFormat()
        {
            return format;
        };
        string getPathing()
        {
            return pathing;
        };
        int getHeight()
        {
            return height;
        }
        int getWidth()
        {
            return width;
        }
    }
}
