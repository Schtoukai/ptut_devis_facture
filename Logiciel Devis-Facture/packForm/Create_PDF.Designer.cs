
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelNewInvoice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isInvoiceButton = new System.Windows.Forms.RadioButton();
            this.isQuoteButton = new System.Windows.Forms.RadioButton();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTVA = new System.Windows.Forms.Label();
            this.labelTCCPrice = new System.Windows.Forms.Label();
            this.textBoxTVA = new System.Windows.Forms.TextBox();
            this.textBoxTTCPrice = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonDeleteAllItem = new System.Windows.Forms.Button();
            this.textBoxTTCTotal = new System.Windows.Forms.TextBox();
            this.labelTTCTotal = new System.Windows.Forms.Label();
            this.textBoxHTTotal = new System.Windows.Forms.TextBox();
            this.labelHTTotal = new System.Windows.Forms.Label();
            this.textBoxPromo = new System.Windows.Forms.TextBox();
            this.labelPromo = new System.Windows.Forms.Label();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.listItem = new System.Windows.Forms.ComboBox();
            this.textBoxAdditionnalAddress = new System.Windows.Forms.TextBox();
            this.labelAdditionnalAddress = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTCTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(30, 118);
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
            this.labelAddress.Location = new System.Drawing.Point(30, 161);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 25);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Adresse";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidate.Location = new System.Drawing.Point(1054, 768);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(193, 37);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(26, 308);
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
            this.labelPhone.Location = new System.Drawing.Point(26, 352);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(106, 25);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Téléphone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 117);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(394, 22);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(165, 160);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(394, 22);
            this.textBoxStreet.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(165, 307);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(394, 22);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(165, 351);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(394, 22);
            this.textBoxPhone.TabIndex = 10;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(30, 392);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(60, 25);
            this.labelMail.TabIndex = 11;
            this.labelMail.Text = "Email";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(165, 392);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(394, 22);
            this.textBoxMail.TabIndex = 12;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(144, 73);
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
            this.labelNumero.Location = new System.Drawing.Point(626, 186);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(81, 25);
            this.labelNumero.TabIndex = 14;
            this.labelNumero.Text = "Numéro";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(714, 189);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(167, 22);
            this.textBoxNumero.TabIndex = 15;
            // 
            // labelpdfInfo
            // 
            this.labelpdfInfo.AutoSize = true;
            this.labelpdfInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpdfInfo.Location = new System.Drawing.Point(776, 73);
            this.labelpdfInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpdfInfo.Name = "labelpdfInfo";
            this.labelpdfInfo.Size = new System.Drawing.Size(366, 36);
            this.labelpdfInfo.TabIndex = 16;
            this.labelpdfInfo.Text = "Information du document";
            // 
            // labelNewInvoice
            // 
            this.labelNewInvoice.AutoSize = true;
            this.labelNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewInvoice.Location = new System.Drawing.Point(460, 9);
            this.labelNewInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewInvoice.Name = "labelNewInvoice";
            this.labelNewInvoice.Size = new System.Drawing.Size(416, 52);
            this.labelNewInvoice.TabIndex = 17;
            this.labelNewInvoice.Text = "Nouveau document";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(927, 187);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(987, 189);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(263, 24);
            this.dateTimePicker.TabIndex = 19;
            // 
            // isInvoiceButton
            // 
            this.isInvoiceButton.AutoSize = true;
            this.isInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isInvoiceButton.Location = new System.Drawing.Point(714, 137);
            this.isInvoiceButton.Name = "isInvoiceButton";
            this.isInvoiceButton.Size = new System.Drawing.Size(99, 29);
            this.isInvoiceButton.TabIndex = 20;
            this.isInvoiceButton.TabStop = true;
            this.isInvoiceButton.Text = "Facture";
            this.isInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // isQuoteButton
            // 
            this.isQuoteButton.AutoSize = true;
            this.isQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isQuoteButton.Location = new System.Drawing.Point(870, 137);
            this.isQuoteButton.Name = "isQuoteButton";
            this.isQuoteButton.Size = new System.Drawing.Size(82, 29);
            this.isQuoteButton.TabIndex = 21;
            this.isQuoteButton.TabStop = true;
            this.isQuoteButton.Text = "Devis";
            this.isQuoteButton.UseVisualStyleBackColor = true;
            this.isQuoteButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedItem.Location = new System.Drawing.Point(625, 241);
            this.labelSelectedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(83, 25);
            this.labelSelectedItem.TabIndex = 23;
            this.labelSelectedItem.Text = "Élement";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.Location = new System.Drawing.Point(653, 297);
            this.labelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(82, 25);
            this.labelUnitPrice.TabIndex = 25;
            this.labelUnitPrice.Text = "Prix H.T";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(627, 325);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(133, 22);
            this.textBoxUnitPrice.TabIndex = 26;
            this.textBoxUnitPrice.Text = "0";
            this.textBoxUnitPrice.TextChanged += new System.EventHandler(this.textBoxUnitPrice_TextChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(812, 297);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(86, 25);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "Quantité";
            // 
            // labelTVA
            // 
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTVA.Location = new System.Drawing.Point(982, 297);
            this.labelTVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(90, 25);
            this.labelTVA.TabIndex = 29;
            this.labelTVA.Text = "TVA (%)";
            // 
            // labelTCCPrice
            // 
            this.labelTCCPrice.AutoSize = true;
            this.labelTCCPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTCCPrice.Location = new System.Drawing.Point(1156, 297);
            this.labelTCCPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCCPrice.Name = "labelTCCPrice";
            this.labelTCCPrice.Size = new System.Drawing.Size(91, 25);
            this.labelTCCPrice.TabIndex = 30;
            this.labelTCCPrice.Text = "Prix TTC";
            // 
            // textBoxTVA
            // 
            this.textBoxTVA.Location = new System.Drawing.Point(960, 325);
            this.textBoxTVA.Name = "textBoxTVA";
            this.textBoxTVA.Size = new System.Drawing.Size(133, 22);
            this.textBoxTVA.TabIndex = 31;
            this.textBoxTVA.Text = "0";
            // 
            // textBoxTTCPrice
            // 
            this.textBoxTTCPrice.Enabled = false;
            this.textBoxTTCPrice.Location = new System.Drawing.Point(1132, 325);
            this.textBoxTTCPrice.Name = "textBoxTTCPrice";
            this.textBoxTTCPrice.Size = new System.Drawing.Size(133, 22);
            this.textBoxTTCPrice.TabIndex = 32;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(701, 376);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(133, 31);
            this.buttonAddItem.TabIndex = 33;
            this.buttonAddItem.Text = "Ajouter";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeColumns = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details,
            this.htPrice,
            this.Quantity,
            this.TVA,
            this.TTCTotal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid.Location = new System.Drawing.Point(45, 436);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.RowHeadersWidth = 51;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.Size = new System.Drawing.Size(1227, 317);
            this.itemGrid.TabIndex = 34;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(870, 376);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(133, 31);
            this.buttonDeleteItem.TabIndex = 35;
            this.buttonDeleteItem.Text = "Supprimer";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonDeleteAllItem
            // 
            this.buttonDeleteAllItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAllItem.Location = new System.Drawing.Point(1033, 376);
            this.buttonDeleteAllItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteAllItem.Name = "buttonDeleteAllItem";
            this.buttonDeleteAllItem.Size = new System.Drawing.Size(133, 31);
            this.buttonDeleteAllItem.TabIndex = 36;
            this.buttonDeleteAllItem.Text = "Réinitialiser";
            this.buttonDeleteAllItem.UseVisualStyleBackColor = true;
            this.buttonDeleteAllItem.Click += new System.EventHandler(this.buttonDeleteAllItem_Click);
            // 
            // textBoxTTCTotal
            // 
            this.textBoxTTCTotal.Enabled = false;
            this.textBoxTTCTotal.Location = new System.Drawing.Point(831, 777);
            this.textBoxTTCTotal.Name = "textBoxTTCTotal";
            this.textBoxTTCTotal.Size = new System.Drawing.Size(133, 22);
            this.textBoxTTCTotal.TabIndex = 38;
            // 
            // labelTTCTotal
            // 
            this.labelTTCTotal.AutoSize = true;
            this.labelTTCTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTCTotal.Location = new System.Drawing.Point(722, 774);
            this.labelTTCTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTTCTotal.Name = "labelTTCTotal";
            this.labelTTCTotal.Size = new System.Drawing.Size(102, 25);
            this.labelTTCTotal.TabIndex = 37;
            this.labelTTCTotal.Text = "Total TTC";
            // 
            // textBoxHTTotal
            // 
            this.textBoxHTTotal.Enabled = false;
            this.textBoxHTTotal.Location = new System.Drawing.Point(499, 776);
            this.textBoxHTTotal.Name = "textBoxHTTotal";
            this.textBoxHTTotal.Size = new System.Drawing.Size(133, 22);
            this.textBoxHTTotal.TabIndex = 40;
            // 
            // labelHTTotal
            // 
            this.labelHTTotal.AutoSize = true;
            this.labelHTTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTTotal.Location = new System.Drawing.Point(405, 774);
            this.labelHTTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHTTotal.Name = "labelHTTotal";
            this.labelHTTotal.Size = new System.Drawing.Size(88, 25);
            this.labelHTTotal.TabIndex = 39;
            this.labelHTTotal.Text = "Total HT";
            // 
            // textBoxPromo
            // 
            this.textBoxPromo.Location = new System.Drawing.Point(175, 777);
            this.textBoxPromo.Name = "textBoxPromo";
            this.textBoxPromo.Size = new System.Drawing.Size(133, 22);
            this.textBoxPromo.TabIndex = 42;
            this.textBoxPromo.Text = "0";
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromo.Location = new System.Drawing.Point(91, 773);
            this.labelPromo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(77, 25);
            this.labelPromo.TabIndex = 41;
            this.labelPromo.Text = "Remise";
            // 
            // quantitySelector
            // 
            this.quantitySelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelector.Location = new System.Drawing.Point(796, 323);
            this.quantitySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.Name = "quantitySelector";
            this.quantitySelector.Size = new System.Drawing.Size(120, 24);
            this.quantitySelector.TabIndex = 44;
            this.quantitySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.ValueChanged += new System.EventHandler(this.quantitySelector_ValueChanged);
            // 
            // listItem
            // 
            this.listItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listItem.FormattingEnabled = true;
            this.listItem.Location = new System.Drawing.Point(716, 242);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(534, 24);
            this.listItem.TabIndex = 43;
            // 
            // textBoxAdditionnalAddress
            // 
            this.textBoxAdditionnalAddress.Location = new System.Drawing.Point(165, 216);
            this.textBoxAdditionnalAddress.Name = "textBoxAdditionnalAddress";
            this.textBoxAdditionnalAddress.Size = new System.Drawing.Size(394, 22);
            this.textBoxAdditionnalAddress.TabIndex = 46;
            // 
            // labelAdditionnalAddress
            // 
            this.labelAdditionnalAddress.AutoSize = true;
            this.labelAdditionnalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionnalAddress.Location = new System.Drawing.Point(26, 199);
            this.labelAdditionnalAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditionnalAddress.Name = "labelAdditionnalAddress";
            this.labelAdditionnalAddress.Size = new System.Drawing.Size(123, 50);
            this.labelAdditionnalAddress.TabIndex = 45;
            this.labelAdditionnalAddress.Text = "Complément\r\nd\'adresse";
            this.labelAdditionnalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(165, 264);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(394, 22);
            this.textBoxZip.TabIndex = 48;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(26, 264);
            this.labelZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(117, 25);
            this.labelZip.TabIndex = 47;
            this.labelZip.Text = "Code postal";
            // 
            // Details
            // 
            this.Details.HeaderText = "Détails";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Details.Width = 406;
            // 
            // htPrice
            // 
            this.htPrice.HeaderText = "Prix H.T";
            this.htPrice.MinimumWidth = 6;
            this.htPrice.Name = "htPrice";
            this.htPrice.ReadOnly = true;
            this.htPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.htPrice.Width = 133;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qté";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 122;
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA";
            this.TVA.MinimumWidth = 6;
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            this.TVA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TVA.Width = 123;
            // 
            // TTCTotal
            // 
            this.TTCTotal.HeaderText = "Total TTC";
            this.TTCTotal.MinimumWidth = 6;
            this.TTCTotal.Name = "TTCTotal";
            this.TTCTotal.ReadOnly = true;
            this.TTCTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TTCTotal.Width = 133;
            // 
            // Create_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 823);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.textBoxAdditionnalAddress);
            this.Controls.Add(this.labelAdditionnalAddress);
            this.Controls.Add(this.quantitySelector);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.textBoxPromo);
            this.Controls.Add(this.labelPromo);
            this.Controls.Add(this.textBoxHTTotal);
            this.Controls.Add(this.labelHTTotal);
            this.Controls.Add(this.textBoxTTCTotal);
            this.Controls.Add(this.labelTTCTotal);
            this.Controls.Add(this.buttonDeleteAllItem);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxTTCPrice);
            this.Controls.Add(this.textBoxTVA);
            this.Controls.Add(this.labelTCCPrice);
            this.Controls.Add(this.labelTVA);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelSelectedItem);
            this.Controls.Add(this.isQuoteButton);
            this.Controls.Add(this.isInvoiceButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNewInvoice);
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
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
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
        private System.Windows.Forms.Label labelNewInvoice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private PDF myPDF = new PDF();
        private RadioButton isInvoiceButton;
        private RadioButton isQuoteButton;
        private Label labelSelectedItem;
        private Label labelUnitPrice;
        private TextBox textBoxUnitPrice;
        private Label labelQuantity;
        private Label labelTVA;
        private Label labelTCCPrice;
        private TextBox textBoxTVA;
        private TextBox textBoxTTCPrice;
        private Button buttonAddItem;
        private DataGridView itemGrid;
        private Button buttonDeleteItem;
        private Button buttonDeleteAllItem;
        private TextBox textBoxTTCTotal;
        private Label labelTTCTotal;
        private TextBox textBoxHTTotal;
        private Label labelHTTotal;
        private TextBox textBoxPromo;
        private Label labelPromo;
        private NumericUpDown quantitySelector;
        private ComboBox listItem;
        private Company entreprise = new Company();
        private TextBox textBoxAdditionnalAddress;
        private Label labelAdditionnalAddress;
        private TextBox textBoxZip;
        private Label labelZip;
        private DataGridViewTextBoxColumn Details;
        private DataGridViewTextBoxColumn htPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TVA;
        private DataGridViewTextBoxColumn TTCTotal;
    }
}