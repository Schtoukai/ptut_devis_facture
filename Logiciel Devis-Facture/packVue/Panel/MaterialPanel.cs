using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class MaterialPanel : AbstractPanel
    {
        private myButton addMateriauButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox list;

        public MaterialPanel()
        {
            list = new System.Windows.Forms.ListBox();
            addMateriauButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addMateriauButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.list);
            addMateriauButton.Text = "Ajouter un Matériau";
            addMateriauButton.BackColor = Color.Lime;
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
            this.Size = new System.Drawing.Size(width, height);
            addMateriauButton.SetSize(this.Width/6, this.Height/12);
            sbar.SetFontSize(this.Height / 12);
            sbar.SetSize(this.Width * 2 / 5, 0);
            list.Size = new System.Drawing.Size(this.Width * 2 / 5, this.Height / 2);
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addMateriauButton.Location = new System.Drawing.Point((this.Size.Width - addMateriauButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMateriauButton.Height * 3 / 2);
            list.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMateriauButton.Height * 5 / 2);
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
