using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Logiciel_Devis_Facture.packForm;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class CustomerPanel : AbstractPanel
    {
        private myButton addCustomerButton;
        private SearchBar sbar;
        private System.Windows.Forms.ListBox list;

        public CustomerPanel()
        {
            list = new System.Windows.Forms.ListBox();
            addCustomerButton = new myButton();
            sbar = new SearchBar();
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.list);
            addCustomerButton.Text = "Ajouter un Client";
            addCustomerButton.BackColor = Color.Lime;
            this.initEventHandler();
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
            addCustomerButton.SetSize(buttonWidth, buttonHeight);
            sbar.SetFontSize(buttonHeight / 5);
            sbar.SetSize(barWidth, 0);
            list.Size = new System.Drawing.Size(barWidth, buttonHeight * 6);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addCustomerButton.Location = new System.Drawing.Point((this.Size.Width - addCustomerButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addCustomerButton.Height * 3 / 2);
            list.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addCustomerButton.Height * 5 / 2);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }
     
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddClient newClientWindow = new AddClient();
            newClientWindow.Show();
        }

        public void initEventHandler()
        {
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
        }

        public override void SetFontSize(int size)
        {
            throw new NotImplementedException();
        }
    }
}
