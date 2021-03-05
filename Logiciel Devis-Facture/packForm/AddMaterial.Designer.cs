
namespace Logiciel_Devis_Facture.packForm
{
    partial class AddMaterial
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
            this.labelNewMaterial = new System.Windows.Forms.Label();
            this.textBoxTVA = new System.Windows.Forms.TextBox();
            this.labelTVA = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewMaterial
            // 
            this.labelNewMaterial.AutoSize = true;
            this.labelNewMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMaterial.Location = new System.Drawing.Point(163, 21);
            this.labelNewMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewMaterial.Name = "labelNewMaterial";
            this.labelNewMaterial.Size = new System.Drawing.Size(381, 52);
            this.labelNewMaterial.TabIndex = 70;
            this.labelNewMaterial.Text = "Nouveau matériel";
            // 
            // textBoxTVA
            // 
            this.textBoxTVA.Location = new System.Drawing.Point(213, 192);
            this.textBoxTVA.Name = "textBoxTVA";
            this.textBoxTVA.Size = new System.Drawing.Size(394, 22);
            this.textBoxTVA.TabIndex = 66;
            // 
            // labelTVA
            // 
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTVA.Location = new System.Drawing.Point(78, 189);
            this.labelTVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(90, 25);
            this.labelTVA.TabIndex = 69;
            this.labelTVA.Text = "TVA (%)";
            this.labelTVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(213, 136);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(394, 22);
            this.textBoxPrice.TabIndex = 65;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(213, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(394, 22);
            this.textBoxName.TabIndex = 64;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(78, 137);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(77, 25);
            this.labelPrice.TabIndex = 68;
            this.labelPrice.Text = "Prix HT";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(78, 94);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 25);
            this.labelName.TabIndex = 67;
            this.labelName.Text = "Nom";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidate.Location = new System.Drawing.Point(245, 244);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(193, 37);
            this.buttonValidate.TabIndex = 71;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 294);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelNewMaterial);
            this.Controls.Add(this.textBoxTVA);
            this.Controls.Add(this.labelTVA);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "AddMaterial";
            this.Text = "Nouveau matériel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewMaterial;
        private System.Windows.Forms.TextBox textBoxTVA;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonValidate;
    }
}