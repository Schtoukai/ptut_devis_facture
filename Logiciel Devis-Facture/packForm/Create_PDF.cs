using Logiciel_Devis_Facture.packModele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    public partial class Create_PDF : Form
    {
        public Create_PDF()
        {
            InitializeComponent();

            entreprise.querryMaterials();
            loadMaterials(entreprise.getListMaterials());
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if(myPDF.generatePDF(entreprise, this))
            {
                this.Visible = false;
            }
        }

        public void loadClient(List<Client> listeClient)
        {
            bool flag = true;
            foreach (Client i in listeClient)
            {
                if (textBoxName.Text == i.getName())
                {
                    textBoxStreet.Text = i.getAddress()[0];
                    textBoxStreet.Enabled = false;
                    textBoxAdditionnalAddress.Text = i.getAddress()[1];
                    textBoxAdditionnalAddress.Enabled = false;
                    textBoxZip.Text = i.getAddress()[2];
                    textBoxZip.Enabled = false;
                    textBoxCity.Text = i.getAddress()[3];
                    textBoxCity.Enabled = false;
                    textBoxPhone.Text = i.getPhone();
                    textBoxPhone.Enabled = false;
                    textBoxMail.Text = i.getMail();
                    textBoxMail.Enabled = false;
                    flag = false;
                }
                else
                {
                    if (flag)
                    {
                        textBoxStreet.Enabled = true;
                        textBoxStreet.Text = "";
                        textBoxAdditionnalAddress.Enabled = true;
                        textBoxAdditionnalAddress.Text = "";
                        textBoxZip.Enabled = true;
                        textBoxZip.Text = "";
                        textBoxCity.Enabled = true;
                        textBoxCity.Text = "";
                        textBoxPhone.Enabled = true;
                        textBoxPhone.Text = "";
                        textBoxMail.Enabled = true;
                        textBoxMail.Text = "";
                    }
                }
            }
        }

        public void loadMaterials(List<Materials> listMaterials)
        {
            foreach (Materials i in listMaterials)
            {
                listItem.Items.Add(i.getNameMaterials());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {}

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(listItem.SelectedItem != null)
            {
                this.itemGrid.Rows.Add(new object[] { listItem.Text, textBoxUnitPrice.Text, quantitySelector.Value, textBoxTVA.Text, textBoxTTCPrice.Text }); ;
            }

            //On réinitialise toutes les zones de saisies
            listItem.SelectedItem = null;
            textBoxUnitPrice.Clear();
            quantitySelector.Value = 1;
            textBoxTVA.Clear();
            textBoxTTCPrice.Clear(); ;
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if(itemGrid.Rows.Count != 0)
            {
                int rowIndex = itemGrid.CurrentCell.RowIndex;
                itemGrid.Rows.RemoveAt(rowIndex);
            }
        }

        private void buttonDeleteAllItem_Click(object sender, EventArgs e)
        {
            itemGrid.Rows.Clear();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 2)
            {
                entreprise.querryClient(textBoxName.Text);
            }   
            else
            {
                entreprise.querryClient();
            }
            this.loadClient(entreprise.getListClient());
        }

        private void setTTCPrice()
        {
            if (textBoxUnitPrice.Text != "" && textBoxTVA.Text != "")
            {
                float TCCPrice = float.Parse(textBoxUnitPrice.Text) * (float)(quantitySelector.Value) * ((float)1 + (float.Parse(textBoxTVA.Text)) / 100);
                textBoxTTCPrice.Text = TCCPrice.ToString();
            }
        }

        private void setHTTotal()
        {

        }

        private void setTTCTotal()
        {

        }

        private void textBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            setTTCPrice();
        }

        private void quantitySelector_ValueChanged(object sender, EventArgs e)
        {
            setTTCPrice();
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //entreprise.querryMaterials();
            //loadMaterials(entreprise.getListMaterials());
        }
    }
}
