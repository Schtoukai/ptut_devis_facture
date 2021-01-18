﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class QuoteAndInvoicePanel : AbstractPanel
    {
        private myButton addDevis_FactureButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox listDevis;
        private System.Windows.Forms.ListBox listFacture;

        public QuoteAndInvoicePanel()
        {
            listDevis = new System.Windows.Forms.ListBox();
            listFacture = new System.Windows.Forms.ListBox();
            addDevis_FactureButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addDevis_FactureButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.listDevis);
            this.Controls.Add(this.listFacture);
            addDevis_FactureButton.Text = "Ajouter un Devis ou une Facture";
            addDevis_FactureButton.BackColor = Color.Lime;
            //this.BackColor = Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TabIndex = 1;
        }
        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            addDevis_FactureButton.SetSize(this.Width / 6, this.Height / 12);
            sbar.SetFontSize(0, this.Height / 12);
            sbar.SetSize(this.Width * 2 / 5, 0);
            listDevis.Size = new System.Drawing.Size(this.Width * 2 / 5, this.Height / 2);
            listFacture.Size = listDevis.Size;
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addDevis_FactureButton.Location = new System.Drawing.Point((this.Size.Width - addDevis_FactureButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addDevis_FactureButton.Height * 3 / 2);
            listDevis.Location = new System.Drawing.Point((this.Size.Width - (2 * sbar.Width)) / 2, addDevis_FactureButton.Height * 5 / 2);
            listFacture.Location = new System.Drawing.Point(listDevis.Size.Width + 1 * sbar.Width / 5, listDevis.Location.Y);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int buttonWidth, int buttonHeight)
        {
            throw new NotImplementedException();
        }
    }
}
