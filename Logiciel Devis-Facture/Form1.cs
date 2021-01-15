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
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entreprisePanel.BringToFront();
            this.WindowState = FormWindowState.Maximized;
            Form1_Resize(sender,e);
            this.clientPanel.addItem("Bonjour");
            this.clientPanel.addItem("Au Revoir");
            this.materiauPanel.addItem("Au Revoir");
            this.materiauPanel.addItem("Bonjour");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            NavLayoutPanel.Width = this.Width;
            NavLayoutPanel.Height = this.Height / 10;

            int buttonWidth = this.Width / 6;
            this.monEntrepriseButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.Devis_FactureButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.ClientButton.SetSize(buttonWidth, NavLayoutPanel.Height);
            this.MateriauButton.SetSize(buttonWidth, NavLayoutPanel.Height);

            int margin = (int)((NavLayoutPanel.Width - 4 * buttonWidth) / 8.25);
            this.monEntrepriseButton.SetMargin(margin, 0, margin, 0);
            this.Devis_FactureButton.SetMargin(margin, 0, margin, 0);
            this.ClientButton.SetMargin(margin, 0, margin, 0);
            this.MateriauButton.SetMargin(margin, 0, margin, 0);

            clientPanel.SetSize(this.Width*4/3, this.Height);
            materiauPanel.SetSize(this.Width*4/3, this.Height);
            devis_FacturePanel.SetSize(this.Width * 4 / 3, this.Height);
            entreprisePanel.SetSize(this.Width * 4 / 3, this.Height);

            clientPanel.SetLocation(0, NavLayoutPanel.Height*3/2);
            materiauPanel.SetLocation(0, NavLayoutPanel.Height*3/2);
            devis_FacturePanel.SetLocation(0, NavLayoutPanel.Height * 3 / 2);
            entreprisePanel.SetLocation(0, NavLayoutPanel.Height * 3 / 2);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            clientPanel.BringToFront();
        }

        private void MateriauButton_Click(object sender, EventArgs e)
        {
            materiauPanel.BringToFront();
        }

        private void Devis_FactureButton_Click(object sender, EventArgs e)
        {
            devis_FacturePanel.BringToFront();
        }

        private void EntrepriseButton_Click(object sender, EventArgs e)
        {
            entreprisePanel.BringToFront();
        }
    }
}
