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
        private myButton addMaterialButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox list;

        public MaterialPanel()
        {
            list = new System.Windows.Forms.ListBox();
            addMaterialButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.list);
            addMaterialButton.Text = "Ajouter un Matériau";
            addMaterialButton.BackColor = Color.Lime;
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
            int buttonWidth = this.Width / 6;
            int buttonHeight = this.Height / 12;
            int barWidth = this.Width * 2 / 5;
            addMaterialButton.SetSize(buttonWidth, buttonHeight);
            sbar.SetFontSize(buttonHeight / 5);
            sbar.SetSize(barWidth, 0);
            list.Size = new System.Drawing.Size(barWidth, buttonHeight * 6);
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addMaterialButton.Location = new System.Drawing.Point((this.Size.Width - addMaterialButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMaterialButton.Height * 3 / 2);
            list.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMaterialButton.Height * 5 / 2);
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
