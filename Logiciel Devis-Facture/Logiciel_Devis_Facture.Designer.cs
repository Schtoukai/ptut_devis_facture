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
            this.monEntrepriseButton = new myButton();
            this.Devis_FactureButton = new myButton();
            this.ClientButton = new myButton();
            this.MateriauButton = new myButton();
            this.clientPanel = new CustomerPanel();
            this.materiauPanel = new MaterialPanel();
            this.devis_FacturePanel = new QuoteAndInvoicePanel();
            this.entreprisePanel = new CompanyPanel();
            this.NavLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavLayoutPanel
            // 
            this.NavLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavLayoutPanel.Controls.Add(this.monEntrepriseButton);
            this.NavLayoutPanel.Controls.Add(this.Devis_FactureButton);
            this.NavLayoutPanel.Controls.Add(this.ClientButton);
            this.NavLayoutPanel.Controls.Add(this.MateriauButton);
            this.NavLayoutPanel.Location = new System.Drawing.Point(1, 0);
            this.NavLayoutPanel.Name = "NavLayoutPanel";
            this.NavLayoutPanel.Size = new System.Drawing.Size(1411, 52);
            this.NavLayoutPanel.TabIndex = 3;
            // 
            // monEntrepriseButton
            // 
            this.monEntrepriseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monEntrepriseButton.FlatAppearance.BorderSize = 0;
            this.monEntrepriseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monEntrepriseButton.ForeColor = System.Drawing.Color.White;
            this.monEntrepriseButton.Location = new System.Drawing.Point(3, 3);
            this.monEntrepriseButton.Name = "monEntrepriseButton";
            this.monEntrepriseButton.Size = new System.Drawing.Size(202, 49);
            this.monEntrepriseButton.TabIndex = 0;
            this.monEntrepriseButton.Text = "Mon Entreprise";
            this.monEntrepriseButton.Click += new System.EventHandler(this.EntrepriseButton_Click);
            // 
            // Devis_FactureButton
            // 
            this.Devis_FactureButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Devis_FactureButton.FlatAppearance.BorderSize = 0;
            this.Devis_FactureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Devis_FactureButton.ForeColor = System.Drawing.Color.White;
            this.Devis_FactureButton.Location = new System.Drawing.Point(211, 3);
            this.Devis_FactureButton.Name = "Devis_FactureButton";
            this.Devis_FactureButton.Size = new System.Drawing.Size(237, 49);
            this.Devis_FactureButton.TabIndex = 1;
            this.Devis_FactureButton.Text = "Devis & Facture";
            this.Devis_FactureButton.Click += new System.EventHandler(this.Devis_FactureButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientButton.FlatAppearance.BorderSize = 0;
            this.ClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientButton.ForeColor = System.Drawing.Color.White;
            this.ClientButton.Location = new System.Drawing.Point(454, 3);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(249, 49);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Mes Clients";
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // MateriauButton
            // 
            this.MateriauButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MateriauButton.FlatAppearance.BorderSize = 0;
            this.MateriauButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MateriauButton.ForeColor = System.Drawing.Color.White;
            this.MateriauButton.Location = new System.Drawing.Point(709, 3);
            this.MateriauButton.Name = "MateriauButton";
            this.MateriauButton.Size = new System.Drawing.Size(313, 49);
            this.MateriauButton.TabIndex = 3;
            this.MateriauButton.Text = "Mes Matériaux";
            this.MateriauButton.Click += new System.EventHandler(this.MateriauButton_Click);
            // 
            // clientPanel
            // 
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(200, 100);
            this.clientPanel.TabIndex = 1;
            // 
            // materiauPanel
            // 
            this.materiauPanel.Location = new System.Drawing.Point(0, 0);
            this.materiauPanel.Name = "materiauPanel";
            this.materiauPanel.Size = new System.Drawing.Size(200, 100);
            this.materiauPanel.TabIndex = 1;
            //
            // devis_facturePanel
            //
            this.devis_FacturePanel.Location = new System.Drawing.Point(0, 0);
            this.devis_FacturePanel.Name = "materiauPanel";
            this.devis_FacturePanel.Size = new System.Drawing.Size(200, 100);
            this.devis_FacturePanel.TabIndex = 1;
            //
            // entreprisePanel
            //
            this.entreprisePanel.Location = new System.Drawing.Point(0, 0);
            this.entreprisePanel.Name = "materiauPanel";
            this.entreprisePanel.Size = new System.Drawing.Size(200, 100);
            this.entreprisePanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.NavLayoutPanel);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.materiauPanel);
            this.Controls.Add(this.devis_FacturePanel);
            this.Controls.Add(this.entreprisePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.NavLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel NavLayoutPanel;
        private myButton monEntrepriseButton;
        private myButton Devis_FactureButton;
        private myButton ClientButton;
        private myButton MateriauButton;
        private CustomerPanel clientPanel;
        private MaterialPanel materiauPanel;
        private QuoteAndInvoicePanel devis_FacturePanel;
        private CompanyPanel entreprisePanel;
    }
}

