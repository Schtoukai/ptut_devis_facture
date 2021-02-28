﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Logiciel_Devis_Facture.packModele;
using System.Data;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class CustomerPanel : AbstractPanel
    {
        private myButton addCustomerButton;
        private SearchBar sbar;
        private DataGridView clientList;

        public CustomerPanel()
        {
            addCustomerButton = new myButton();
            sbar = new SearchBar();
            clientList = new DataGridView();
            clientList.ColumnCount = 4;
            clientList.Columns[0].Name = "Nom";
            clientList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientList.Columns[1].Name = "Adresse";
            clientList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientList.Columns[2].Name = "Mail";
            clientList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientList.Columns[3].Name = "Téléphone";
            clientList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientList.RowHeadersVisible = false;
            clientList.AllowUserToAddRows = false;
            clientList.AllowUserToDeleteRows = false;
            clientList.Enabled = false;
            foreach (DataGridViewColumn header in clientList.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.sbar);
            this.Controls.Add(this.clientList);
            addCustomerButton.Text = "Ajouter un Client";
            addCustomerButton.BackColor = Color.Lime;
            sbar.TextChanged += new System.EventHandler(TextChanged_Sbar);
            DataTable table = Client.selectCustomer("");
            clientList.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                string[] adress = { row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                Client c = new Client(row[0].ToString(), row[1].ToString(), adress, row[6].ToString(), row[7].ToString());
                clientList.Rows.Add(c.getName(), c.getAdress(), c.getMail(), c.getPhone());
            }
            clientList.Refresh();
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
            addCustomerButton.SetSize(buttonWidth, buttonHeight);
            sbar.SetFontSize(buttonHeight / 5);
            sbar.SetSize(barWidth, 0);
            clientList.Size = new System.Drawing.Size(barWidth, buttonHeight * 6);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            addCustomerButton.Location = new System.Drawing.Point((this.Size.Width - addCustomerButton.Width) / 2, 0);
            sbar.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addCustomerButton.Height * 3 / 2);
            clientList.Location = new System.Drawing.Point((this.Size.Width - sbar.Width) / 2, addCustomerButton.Height * 5 / 2);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int size)
        {
            throw new NotImplementedException();
        }

        private void TextChanged_Sbar(object sender, EventArgs e)
        {
            DataTable table = Client.selectCustomer(sbar.Text);
            clientList.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                string[] adress = { row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                Client c = new Client(row[0].ToString(), row[1].ToString(), adress, row[6].ToString(), row[7].ToString());
                clientList.Rows.Add(c.getName(),c.getAdress(),c.getMail(),c.getPhone());
            }
            clientList.Refresh();
        }
    }
}
