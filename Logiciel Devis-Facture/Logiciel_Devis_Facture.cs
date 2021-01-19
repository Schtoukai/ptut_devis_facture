using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logiciel_Devis_Facture.packVue;

namespace Logiciel_Devis_Facture
{   
    public partial class Logiciel_Devis_Facture : Form
    { 

        public Logiciel_Devis_Facture()
        {
            InitializeComponent();
        }

        private void Logiciel_Load(object sender, EventArgs e)
        {
            companyPanel.BringToFront();
            this.WindowState = FormWindowState.Maximized;
            Logiciel_Resize(sender,e);
            this.customerPanel.addItem("Bonjour");
            this.customerPanel.addItem("Au Revoir");
            this.materialPanel.addItem("Au Revoir");
            this.materialPanel.addItem("Bonjour");
        }

        private void Logiciel_Resize(object sender, EventArgs e)
        {

            NavLayoutPanel.Width = this.Width;
            NavLayoutPanel.Height = this.Height / 10;

            int buttonWidth = this.Width / 6;
            this.myCompanyButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.Quote_pdfButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.CustomerButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.MaterialButton.SetSize(buttonWidth, NavLayoutPanel.Height);

            int margin = (int)((NavLayoutPanel.Width - 4 * buttonWidth) / 8.25);
            this.myCompanyButton.SetMargin(margin, 0, margin, 0);
            this.Quote_pdfButton.SetMargin(margin, 0, margin, 0);
            this.CustomerButton.SetMargin(margin, 0, margin, 0);
            this.MaterialButton.SetMargin(margin, 0, margin, 0);

            customerPanel.SetSize(this.Width*4/3, this.Height);
            materialPanel.SetSize(this.Width*4/3, this.Height);
            quote_pdfPanel.SetSize(this.Width * 4 / 3, this.Height);
            companyPanel.SetSize(this.Width * 4 / 3, this.Height);

            customerPanel.SetLocation(0, NavLayoutPanel.Height*3/2);
            materialPanel.SetLocation(0, NavLayoutPanel.Height*3/2);
            quote_pdfPanel.SetLocation(0, NavLayoutPanel.Height * 3 / 2);
            companyPanel.SetLocation(0, NavLayoutPanel.Height * 3 / 2);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            customerPanel.BringToFront();
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {
            materialPanel.BringToFront();
        }

        private void Quote_pdfButton_Click(object sender, EventArgs e)
        {
            quote_pdfPanel.BringToFront();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            companyPanel.BringToFront();
        }
    }
}
