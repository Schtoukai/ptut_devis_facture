using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packVue
{
    interface PanelTool
    {
        void SetSize(int width, int height);
        void SetLocation(int x, int y);
        void SetMargin(int left, int top, int right, int bottom);
    }
}
