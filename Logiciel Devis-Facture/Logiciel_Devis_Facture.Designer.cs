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
            this.Quote_InvoiceButton = new myButton();
            this.CustomerButton = new myButton();
            this.MaterialButton = new myButton();
            this.customerPanel = new CustomerPanel();
            this.materialPanel = new MaterialPanel();
            this.quote_InvoicePanel = new QuoteAndInvoicePanel();
            this.companyPanel = new CompanyPanel();
            this.NavLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavLayoutPanel
            // 
            this.NavLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavLayoutPanel.Controls.Add(this.myCompanyButton);
            this.NavLayoutPanel.Controls.Add(this.Quote_InvoiceButton);
            this.NavLayoutPanel.Controls.Add(this.CustomerButton);
            this.NavLayoutPanel.Controls.Add(this.MaterialButton);
            this.NavLayoutPanel.Location = new System.Drawing.Point(1, 0);
            this.NavLayoutPanel.Name = "NavLayoutPanel";
            this.NavLayoutPanel.Size = new System.Drawing.Size(1411, 52);
            this.NavLayoutPanel.TabIndex = 3;
            // 
            // myCompanyButton
            // 
            this.myCompanyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myCompanyButton.FlatAppearance.BorderSize = 0;
            this.myCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCompanyButton.ForeColor = System.Drawing.Color.White;
            this.myCompanyButton.Location = new System.Drawing.Point(3, 3);
            this.myCompanyButton.Name = "monEntrepriseButton";
            this.myCompanyButton.Size = new System.Drawing.Size(202, 49);
            this.myCompanyButton.TabIndex = 0;
            this.myCompanyButton.Text = "Mon Entreprise";
            this.myCompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // Quote_InvoiceButton
            // 
            this.Quote_InvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quote_InvoiceButton.FlatAppearance.BorderSize = 0;
            this.Quote_InvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quote_InvoiceButton.ForeColor = System.Drawing.Color.White;
            this.Quote_InvoiceButton.Location = new System.Drawing.Point(211, 3);
            this.Quote_InvoiceButton.Name = "Quote_InvoiceButton";
            this.Quote_InvoiceButton.Size = new System.Drawing.Size(237, 49);
            this.Quote_InvoiceButton.TabIndex = 1;
            this.Quote_InvoiceButton.Text = "Devis & Facture";
            this.Quote_InvoiceButton.Click += new System.EventHandler(this.Quote_InvoiceButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerButton.FlatAppearance.BorderSize = 0;
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.ForeColor = System.Drawing.Color.White;
            this.CustomerButton.Location = new System.Drawing.Point(454, 3);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(249, 49);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Mes Clients";
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // MaterialButton
            // 
            this.MaterialButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaterialButton.FlatAppearance.BorderSize = 0;
            this.MaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaterialButton.ForeColor = System.Drawing.Color.White;
            this.MaterialButton.Location = new System.Drawing.Point(709, 3);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(313, 49);
            this.MaterialButton.TabIndex = 3;
            this.MaterialButton.Text = "Mes Matériaux";
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // customerPanel
            // 
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(200, 100);
            this.customerPanel.TabIndex = 1;
            // 
            // materialPanel
            // 
            this.materialPanel.Location = new System.Drawing.Point(0, 0);
            this.materialPanel.Name = "materialPanel";
            this.materialPanel.Size = new System.Drawing.Size(200, 100);
            this.materialPanel.TabIndex = 1;
            //
            // quote_InvoicePanel
            //
            this.quote_InvoicePanel.Location = new System.Drawing.Point(0, 0);
            this.quote_InvoicePanel.Name = "materialPanel";
            this.quote_InvoicePanel.Size = new System.Drawing.Size(200, 100);
            this.quote_InvoicePanel.TabIndex = 1;
            //
            // companyPanel
            //
            this.companyPanel.Location = new System.Drawing.Point(0, 0);
            this.companyPanel.Name = "materialPanel";
            this.companyPanel.Size = new System.Drawing.Size(200, 100);
            this.companyPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.NavLayoutPanel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.materialPanel);
            this.Controls.Add(this.quote_InvoicePanel);
            this.Controls.Add(this.companyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Logiciel_Load);
            this.Resize += new System.EventHandler(this.Logiciel_Resize);
            this.NavLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel NavLayoutPanel;
        private myButton myCompanyButton;
        private myButton Quote_InvoiceButton;
        private myButton CustomerButton;
        private myButton MaterialButton;
        private CustomerPanel customerPanel;
        private MaterialPanel materialPanel;
        private QuoteAndInvoicePanel quote_InvoicePanel;
        private CompanyPanel companyPanel;
    }
}

