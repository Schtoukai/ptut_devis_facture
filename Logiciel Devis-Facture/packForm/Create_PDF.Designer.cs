
using Logiciel_Devis_Facture.packModele;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    partial class Create_PDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelpdfInfo = new System.Windows.Forms.Label();
            this.labelNewpdf = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isFactureButton = new System.Windows.Forms.RadioButton();
            this.isQuoteButton = new System.Windows.Forms.RadioButton();
            this.myPDF = new PDF();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(38, 149);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(38, 200);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 25);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Adresse";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidate.Location = new System.Drawing.Point(442, 421);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(273, 50);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(38, 258);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 25);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Ville";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(38, 314);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(106, 25);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Téléphone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 152);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(365, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(151, 203);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(365, 22);
            this.textBoxStreet.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(151, 262);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(365, 22);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(151, 317);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(365, 22);
            this.textBoxPhone.TabIndex = 10;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(38, 371);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(60, 25);
            this.labelMail.TabIndex = 11;
            this.labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(151, 371);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(365, 22);
            this.textBoxMail.TabIndex = 12;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(118, 94);
            this.labelClientInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(320, 36);
            this.labelClientInfo.TabIndex = 13;
            this.labelClientInfo.Text = "Informations du client";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(622, 201);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(81, 25);
            this.labelNumero.TabIndex = 14;
            this.labelNumero.Text = "Numéro";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Enabled = false;
            this.textBoxNumero.Location = new System.Drawing.Point(710, 204);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(365, 22);
            this.textBoxNumero.TabIndex = 15;
            // 
            // labelpdfInfo
            // 
            this.labelpdfInfo.AutoSize = true;
            this.labelpdfInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpdfInfo.Location = new System.Drawing.Point(687, 94);
            this.labelpdfInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpdfInfo.Name = "labelpdfInfo";
            this.labelpdfInfo.Size = new System.Drawing.Size(366, 36);
            this.labelpdfInfo.TabIndex = 16;
            this.labelpdfInfo.Text = "Information du document";
            // 
            // labelNewpdf
            // 
            this.labelNewpdf.AutoSize = true;
            this.labelNewpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewpdf.Location = new System.Drawing.Point(367, 19);
            this.labelNewpdf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewpdf.Name = "labelNewpdf";
            this.labelNewpdf.Size = new System.Drawing.Size(416, 52);
            this.labelNewpdf.TabIndex = 17;
            this.labelNewpdf.Text = "Nouveau document";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(622, 259);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(710, 262);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // isFactureButton
            // 
            this.isFactureButton.AutoSize = true;
            this.isFactureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isFactureButton.Location = new System.Drawing.Point(710, 149);
            this.isFactureButton.Name = "isFactureButton";
            this.isFactureButton.Size = new System.Drawing.Size(87, 24);
            this.isFactureButton.TabIndex = 20;
            this.isFactureButton.TabStop = true;
            this.isFactureButton.Text = "Facture";
            this.isFactureButton.UseVisualStyleBackColor = true;
            // 
            // isQuoteButton
            // 
            this.isQuoteButton.AutoSize = true;
            this.isQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isQuoteButton.Location = new System.Drawing.Point(866, 149);
            this.isQuoteButton.Name = "isQuoteButton";
            this.isQuoteButton.Size = new System.Drawing.Size(73, 24);
            this.isQuoteButton.TabIndex = 21;
            this.isQuoteButton.TabStop = true;
            this.isQuoteButton.Text = "Devis";
            this.isQuoteButton.UseVisualStyleBackColor = true;
            this.isQuoteButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Create_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 493);
            this.Controls.Add(this.isQuoteButton);
            this.Controls.Add(this.isFactureButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNewpdf);
            this.Controls.Add(this.labelpdfInfo);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelClientInfo);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Create_PDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelpdfInfo;
        private System.Windows.Forms.Label labelNewpdf;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private PDF myPDF;
        private RadioButton isFactureButton;
        private RadioButton isQuoteButton;
    }
}