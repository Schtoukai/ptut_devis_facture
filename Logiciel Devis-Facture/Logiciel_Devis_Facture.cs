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

            int buttonWidth = this.Width / NavLayoutPanel.Controls.Count;

            this.myCompanyButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.Quote_InvoiceButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.CustomerButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.MaterialButton.SetSize(buttonWidth, NavLayoutPanel.Height);

            int margin = 0;

            this.myCompanyButton.SetMargin(margin, 0, margin, 0);
            this.Quote_InvoiceButton.SetMargin(margin, 0, margin, 0);
            this.CustomerButton.SetMargin(margin, 0, margin, 0);
            this.MaterialButton.SetMargin(margin, 0, margin, 0);

            int panelWidth = this.Width * 4 / 3;

            customerPanel.SetSize(panelWidth, this.Height);
            materialPanel.SetSize(panelWidth, this.Height);
            quote_InvoicePanel.SetSize(panelWidth, this.Height);
            companyPanel.SetSize(panelWidth, this.Height);

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
