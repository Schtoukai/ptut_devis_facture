using Logiciel_Devis_Facture.packModele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class QuoteAndpdfPanel : AbstractPanel
    {
        private myButton addQuote_InvoiceButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox listDevis;
        private System.Windows.Forms.ListBox listFacture;
        private Company entreprise;

        public QuoteAndpdfPanel(Company entreprise)
        {
            listDevis = new System.Windows.Forms.ListBox();
            listFacture = new System.Windows.Forms.ListBox();
            addQuote_InvoiceButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addQuote_InvoiceButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.listDevis);
            this.Controls.Add(this.listFacture);
            addQuote_InvoiceButton.Text = "Ajouter un Devis ou une Facture";
            addQuote_InvoiceButton.BackColor = Color.Lime;
            this.initEventHandler();
            this.entreprise = entreprise;
        }
        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
            int buttonWidth = this.Width / 6;
            int buttonHeight = this.Height / 12;
            int barWidth = this.Width * 2 / 5;
            addQuote_InvoiceButton.SetSize(buttonWidth, buttonHeight);
            sbar.SetFontSize(buttonHeight/5);
            sbar.SetSize(barWidth, 0);
            listDevis.Size = new System.Drawing.Size(barWidth, buttonHeight*6);
            listFacture.Size = listDevis.Size;
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addQuote_InvoiceButton.Location = new System.Drawing.Point((this.Size.Width - addQuote_InvoiceButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addQuote_InvoiceButton.Height * 3 / 2);
            listDevis.Location = new System.Drawing.Point(this.Size.Width/2 - sbar.Width, addQuote_InvoiceButton.Height * 5 / 2);
            listFacture.Location = new System.Drawing.Point(listDevis.Size.Width + sbar.Width / 5, listDevis.Location.Y);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }
        private void addDevis_Facture_Click(object sender, EventArgs e)
        {
            Create_PDF formulaire = new Create_PDF();
            if(entreprise.querryClient())
            {
                formulaire.Show();
            }
        }

        public void initEventHandler()
        {
            this.addQuote_InvoiceButton.Click += new System.EventHandler(this.addDevis_Facture_Click);
        }

        public override void SetFontSize(int size)
        {
            throw new NotImplementedException();
        }
    }
}
