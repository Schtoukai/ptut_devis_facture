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
            Console.WriteLine("Fentre: " + this.Width);
            NavLayoutPanel.Height = this.Height / 10;

            int buttonWidth = this.Width / NavLayoutPanel.Controls.Count;

            this.myCompanyButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.Quote_InvoiceButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.CustomerButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.MaterialButton.SetSize(buttonWidth, NavLayoutPanel.Height);

            int margin = 0;

            this.myCompanyButton.SetMargin(margin, margin, margin, margin);
            this.Quote_InvoiceButton.SetMargin(margin, margin, margin, margin);
            this.CustomerButton.SetMargin(margin, margin, margin, margin);
            this.MaterialButton.SetMargin(margin, margin, margin, margin);

            customerPanel.SetSize(this.Width, this.Height);
            materialPanel.SetSize(this.Width, this.Height);
            quote_InvoicePanel.SetSize(this.Width, this.Height);
            companyPanel.SetSize(this.Width, this.Height);

            int locationPanelonY = NavLayoutPanel.Height * 3 / 2;

            customerPanel.SetLocation(0, locationPanelonY);
            materialPanel.SetLocation(0, locationPanelonY);
            quote_InvoicePanel.SetLocation(0, locationPanelonY);
            companyPanel.SetLocation(0, locationPanelonY);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            customerPanel.BringToFront();
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {
            materialPanel.BringToFront();
        }

        private void Quote_InvoiceButton_Click(object sender, EventArgs e)
        {
            quote_InvoicePanel.BringToFront();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            companyPanel.BringToFront();
        }
    }
}
