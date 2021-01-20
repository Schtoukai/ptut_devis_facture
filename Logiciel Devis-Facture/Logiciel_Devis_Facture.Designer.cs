using Logiciel_Devis_Facture.packVue;
using Logiciel_Devis_Facture.packVue.Panel;
using System;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    partial class Logiciel_Devis_Facture
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavLayoutPanel = new FlowLayoutPanel();
            this.myCompanyButton = new myButton();
            this.Quote_pdfButton = new myButton();
            this.CustomerButton = new myButton();
            this.MaterialButton = new myButton();
            this.customerPanel = new CustomerPanel();
            this.materialPanel = new MaterialPanel();
            this.quote_pdfPanel = new QuoteAndpdfPanel();
            this.companyPanel = new CompanyPanel();
            // 
            // NavLayoutPanel
            // 
            this.NavLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavLayoutPanel.Controls.Add(this.myCompanyButton);
            this.NavLayoutPanel.Controls.Add(this.Quote_pdfButton);
            this.NavLayoutPanel.Controls.Add(this.CustomerButton);
            this.NavLayoutPanel.Controls.Add(this.MaterialButton);
            // 
            // myCompanyButton
            // 
            this.myCompanyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myCompanyButton.FlatAppearance.BorderSize = 0;
            this.myCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCompanyButton.ForeColor = System.Drawing.Color.White;
            this.myCompanyButton.Text = "Mon Entreprise";
            this.myCompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // Quote_pdfButton
            // 
            this.Quote_InvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quote_InvoiceButton.FlatAppearance.BorderSize = 0;
            this.Quote_InvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quote_InvoiceButton.ForeColor = System.Drawing.Color.White;
            this.Quote_InvoiceButton.Text = "Devis et Factures";
            this.Quote_InvoiceButton.Click += new System.EventHandler(this.Quote_InvoiceButton_Click);
            //
            // CustomerButton
            //
            this.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerButton.FlatAppearance.BorderSize = 0;
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.ForeColor = System.Drawing.Color.White;
            this.CustomerButton.Text = "Mes Clients";
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // MaterialButton
            // 
            this.MaterialButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaterialButton.FlatAppearance.BorderSize = 0;
            this.MaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaterialButton.ForeColor = System.Drawing.Color.White;
            this.MaterialButton.Text = "Mes Matériaux";
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // customerPanel
            // 
            this.customerPanel.Name = "customerPanel";
            // 
            // materialPanel
            // 
            this.materialPanel.Name = "materialPanel";
            //
            // quote_pdfPanel
            //
            this.quote_InvoicePanel.Name = "materialPanel";
            //
            // companyPanel
            //
            this.companyPanel.Name = "materialPanel";
            // 
            // Logiciel
            this.Controls.Add(this.NavLayoutPanel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.materialPanel);
            this.Controls.Add(this.quote_pdfPanel);
            this.Controls.Add(this.companyPanel);
            this.Name = "Fenetre Principale";
            this.Text = "Logiciel Devis Factures";
            this.Load += new System.EventHandler(this.Logiciel_Load);
            this.Resize += new System.EventHandler(this.Logiciel_Resize);
            this.NavLayoutPanel.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel NavLayoutPanel;
        private myButton myCompanyButton;
        private myButton Quote_pdfButton;
        private myButton CustomerButton;
        private myButton MaterialButton;
        private CustomerPanel customerPanel;
        private MaterialPanel materialPanel;
        private QuoteAndpdfPanel quote_pdfPanel;
        private CompanyPanel companyPanel;
    }
}

