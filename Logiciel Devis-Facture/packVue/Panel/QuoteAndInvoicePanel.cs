using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class QuoteAndInvoicePanel : AbstractPanel
    {
        private myButton addQuote_InvoiceButton;
        private SearchBar sbar;
        //private System.Windows.Forms.ListBox listDevis;
        //private System.Windows.Forms.ListBox listFacture;
        private DataGridView quoteList;
        private DataGridView invoiceList;

        public QuoteAndInvoicePanel()
        {
            //listDevis = new System.Windows.Forms.ListBox();
            //listFacture = new System.Windows.Forms.ListBox();
            quoteList = new DataGridView();
            quoteList.ColumnCount = 3;
            quoteList.Columns[0].Name = "Numéro";
            quoteList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quoteList.Columns[1].Name = "Nom";
            quoteList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quoteList.Columns[2].Name = "Date";
            quoteList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quoteList.RowHeadersVisible = false;
            quoteList.AllowUserToAddRows = false;
            quoteList.AllowUserToDeleteRows = false;
            quoteList.Enabled = false;
            foreach (DataGridViewColumn header in quoteList.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            quoteList.ClearSelection();
            invoiceList = new DataGridView();
            invoiceList.ColumnCount = 3;
            invoiceList.Columns[0].Name = "Numéro";
            invoiceList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            invoiceList.Columns[1].Name = "Nom";
            invoiceList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            invoiceList.Columns[2].Name = "Date";
            invoiceList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            invoiceList.RowHeadersVisible = false;
            invoiceList.AllowUserToAddRows = false;
            invoiceList.AllowUserToDeleteRows = false;
            invoiceList.Enabled = false;
            foreach (DataGridViewColumn header in invoiceList.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            quoteList.Columns[1].Name = "Nom";
            quoteList.Columns[2].Name = "Date";
            invoiceList = new DataGridView();
            addQuote_InvoiceButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addQuote_InvoiceButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.quoteList);
            this.Controls.Add(this.invoiceList);
            addQuote_InvoiceButton.Text = "Ajouter un Devis ou une Facture";
            addQuote_InvoiceButton.BackColor = Color.Lime;
            this.initEventHandler();
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
            quoteList.Size = new System.Drawing.Size(barWidth, buttonHeight*6);
            invoiceList.Size = quoteList.Size;
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addQuote_InvoiceButton.Location = new System.Drawing.Point((this.Size.Width - addQuote_InvoiceButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addQuote_InvoiceButton.Height * 3 / 2);
            quoteList.Location = new System.Drawing.Point(this.Size.Width/2 - sbar.Width, addQuote_InvoiceButton.Height * 5 / 2);
            invoiceList.Location = new System.Drawing.Point(quoteList.Size.Width + sbar.Width / 5, quoteList.Location.Y);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }
        private void addQuote_Invoice_Click(object sender, EventArgs e)
        {
            Create_PDF formulaire = new Create_PDF();
            formulaire.Show();
        }

        public void initEventHandler()
        {
            this.addQuote_InvoiceButton.Click += new System.EventHandler(this.addQuote_Invoice_Click);
        }

        public override void SetFontSize(int size)
        {
            throw new NotImplementedException();
        }
    }
}
