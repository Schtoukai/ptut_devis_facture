using Logiciel_Devis_Facture.packModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    public partial class Create_PDF : Form
    {

        public Create_PDF()
        {
            InitializeComponent();
            
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            myPDF.generatePDF(textBoxName, textBoxStreet, textBoxCity, textBoxPhone, textBoxMail);
            this.Visible = false;
        }
    }
}
