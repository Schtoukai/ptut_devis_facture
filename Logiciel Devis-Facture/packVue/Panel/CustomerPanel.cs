using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class CustomerPanel : AbstractPanel
    {
        private myButton addClientButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox list;

        public CustomerPanel()
        {
            list = new System.Windows.Forms.ListBox();
            addClientButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.list);
            addClientButton.Text = "Ajouter un Client";
            addClientButton.BackColor = Color.Lime;
            //this.BackColor = Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TabIndex = 1;
        }

        public void addItem(String str)
        {
            list.BeginUpdate();
            list.Items.Add(str);
            list.EndUpdate();
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            addClientButton.SetSize(this.Width/6, this.Height/12);
            sbar.SetFontSize(this.Height / 12);
            sbar.SetSize(this.Width*2/5, 0);
            list.Size = new System.Drawing.Size(this.Width * 2 / 5, this.Height / 2);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addClientButton.Location = new System.Drawing.Point((this.Size.Width - addClientButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addClientButton.Height * 3 / 2);
            list.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addClientButton.Height * 5 / 2);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int size)
        {
            throw new NotImplementedException();
        }
    }
}
