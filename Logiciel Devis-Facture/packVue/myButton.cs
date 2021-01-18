using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packVue
{
    class myButton : System.Windows.Forms.Button, PanelTool
    {
        public myButton()
        {

        }

        public void SetFontSize(int buttonWidth,int buttonHeight)
        {
            int fontSize = buttonHeight / 6;
            if(fontSize>0)
                this.Font = new System.Drawing.Font(this.Font.Name, fontSize);
        }

        public void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
            this.SetFontSize(width, height);
        }

        public void SetMargin(int left, int top, int right, int bottom)
        {
            this.Margin = new System.Windows.Forms.Padding(left, top, right, bottom);
        }

        public void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
        }
    }
}
