using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class MaterialPanel : AbstractPanel
    {
        private myButton addMaterialButton;
        private SearchBar sbar;
        private DataGridView materialList;

        public MaterialPanel()
        {
            materialList = new DataGridView();
            addMaterialButton = new myButton();
            sbar = new SearchBar();
            materialList = new DataGridView();
            materialList.ColumnCount = 4;
            materialList.Columns[0].Name = "Nom";
            materialList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialList.Columns[1].Name = "Adresse";
            materialList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialList.Columns[2].Name = "Mail";
            materialList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialList.Columns[3].Name = "Téléphone";
            materialList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialList.RowHeadersVisible = false;
            materialList.AllowUserToAddRows = false;
            materialList.AllowUserToDeleteRows = false;
            materialList.Enabled = false;
            foreach (DataGridViewColumn header in materialList.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            materialList.ClearSelection();
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.materialList);
            addMaterialButton.Text = "Ajouter un Matériau";
            addMaterialButton.BackColor = Color.Lime;
        }

        public void addItem(String str)
        {
            /*list.BeginUpdate();
            list.Items.Add(str);
            list.EndUpdate();*/
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
            materialList.Size = new System.Drawing.Size(barWidth, buttonHeight * 6);
        }
        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addMaterialButton.Location = new System.Drawing.Point((this.Size.Width - addMaterialButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMaterialButton.Height * 3 / 2);
            materialList.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addMaterialButton.Height * 5 / 2);
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
