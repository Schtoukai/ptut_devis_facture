using System;
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
            if(myPDF.generatePDF(textBoxName, textBoxStreet, textBoxCity, textBoxPhone, textBoxMail) == true)
            {
                this.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {}
    }
}
