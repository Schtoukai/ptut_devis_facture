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
            this.textBoxNumero.Text = (entreprise.querryNumero() + 1).ToString();
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
            if(listItem.SelectedItem != null && isOnlyDigits(textBoxUnitPrice.Text))
            {
                this.itemGrid.Rows.Add(new object[] { listItem.Text, textBoxUnitPrice.Text, quantitySelector.Value, textBoxTVA.Text, textBoxTTCPrice.Text }); ;
            }

            //On réinitialise toutes les zones de saisies
            listItem.SelectedItem = null;
            textBoxUnitPrice.Clear();
            quantitySelector.Value = 1;
            textBoxTVA.Clear();
            textBoxTTCPrice.Clear(); ;

            this.setHTTotal();
            this.setTTCTotal();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if(itemGrid.Rows.Count != 0)
            {
                int rowIndex = itemGrid.CurrentCell.RowIndex;
                itemGrid.Rows.RemoveAt(rowIndex);
            }
            this.setHTTotal();
            this.setTTCTotal();
        }

        private void buttonDeleteAllItem_Click(object sender, EventArgs e)
        {
            itemGrid.Rows.Clear();
            this.setHTTotal();
            this.setTTCTotal();
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
            if (textBoxUnitPrice.Text != "" && isOnlyDigits(textBoxUnitPrice.Text) && textBoxTVA.Text != "")
            {
                float TCCPrice = float.Parse(textBoxUnitPrice.Text) * (float)(quantitySelector.Value) * ((float)1 + (float.Parse(textBoxTVA.Text)) / 100);
                textBoxTTCPrice.Text = Math.Round(TCCPrice, 2).ToString();
            }
        }

        private void setHTTotal()
        {
            float HTTotal = 0;
            float unitPrice = 0;
            float quantity = 0;
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                if(float.TryParse(itemGrid.Rows[i].Cells[1].Value.ToString(), out unitPrice) && float.TryParse(itemGrid.Rows[i].Cells[2].Value.ToString(), out quantity))
                {
                    HTTotal += unitPrice * quantity;
                }
            }
            if (textBoxPromo.Text != "")
            {
                if (amountButton.Checked == true)
                {
                    textBoxHTTotal.Text = (Math.Round(HTTotal, 2) - float.Parse(textBoxPromo.Text)).ToString();
                }
                else
                {
                    textBoxHTTotal.Text = (Math.Round(HTTotal, 2) - (float.Parse(textBoxPromo.Text) / 100 * Math.Round(HTTotal, 2))).ToString();
                }
            }
        }

        private void setTTCTotal()
        {
            float TTCTotal = 0;
            float TTCPrice = 0;
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                if (float.TryParse(itemGrid.Rows[i].Cells[4].Value.ToString(), out TTCPrice))
                {
                    TTCTotal += TTCPrice;
                }
            }
            if (textBoxPromo.Text != "")
            {
                if (amountButton.Checked == true)
                {
                    textBoxTTCTotal.Text = Math.Round((Math.Round(TTCTotal, 2) - float.Parse(textBoxPromo.Text)), 2).ToString();
                }
                else
                {
                    textBoxTTCTotal.Text = Math.Round((Math.Round(TTCTotal, 2) - (float.Parse(textBoxPromo.Text) / 100 * Math.Round(TTCTotal, 2))), 2).ToString();
                }
            }
        }

        public float getSousTotal()
        {
            float HTTotal = 0;
            float unitPrice = 0;
            float quantity = 0;
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                if (float.TryParse(itemGrid.Rows[i].Cells[1].Value.ToString(), out unitPrice) && float.TryParse(itemGrid.Rows[i].Cells[2].Value.ToString(), out quantity))
                {
                    HTTotal += unitPrice * quantity;
                }
            }
            return (float)Math.Round(HTTotal, 2);
        }

        public string getTotalTVA()
        {
            float TCC = float.Parse(textBoxTTCTotal.Text);
            float HT = float.Parse(textBoxHTTotal.Text);
            return Math.Round((TCC - HT), 2).ToString() + "€";
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
            if(listItem.SelectedItem != null)
            {
                textBoxUnitPrice.Text = entreprise.getListMaterials()[listItem.SelectedIndex].getPrice().ToString();
                textBoxTVA.Text = entreprise.getListMaterials()[listItem.SelectedIndex].getTVA().ToString();
            }
            this.setTTCPrice();
        }

        bool isOnlyDigits(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void textBoxPromo_TextChanged(object sender, EventArgs e)
        {
            if(isOnlyDigits(textBoxPromo.Text) && textBoxPromo.Text.Length != 0)
            {
                if(float.Parse(textBoxHTTotal.Text) >= float.Parse(textBoxPromo.Text))
                {
                    this.setHTTotal();
                    this.setTTCTotal();
                }
            }
        }

        private void amountButton_CheckedChanged(object sender, EventArgs e)
        {
            if(amountButton.Checked == true)
            {
                this.setHTTotal();
                this.setTTCTotal();
            }
        }

        private void percentageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (percentageButton.Checked == true)
            {
                this.setHTTotal();
                this.setTTCTotal();
            }
        }
    }
}
