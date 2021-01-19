using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packVue
{
    abstract class AbstractPanel : System.Windows.Forms.Panel, PanelTool
    {
        abstract public void SetLocation(int x, int y);

        abstract public void SetMargin(int left, int top, int right, int bottom);

        abstract public void SetSize(int width, int height);

        abstract public void SetFontSize(int buttonWidth, int buttonHeight);
    }
}
