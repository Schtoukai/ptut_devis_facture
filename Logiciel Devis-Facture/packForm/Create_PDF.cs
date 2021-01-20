using System;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    public partial class Create_PDF : Form
    {

        public Create_PDF()
        {
            myPDF = new packModele.PDF();
            
            InitializeComponent();

            //Temporaire pour tester (à supprimer plus tard)
            listItem.Items.Add("Item 1");
            listItem.Items.Add("Item 2");
            listItem.Items.Add("Item 3");
            listItem.Items.Add("Item 4");
            listItem.Items.Add("Item 5");
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if(myPDF.generatePDF(textBoxName, textBoxStreet, textBoxCity, textBoxPhone, textBoxMail, itemGrid) == true)
            {
                this.Visible = false;
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
            textBoxTTCPrice.Clear();
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
    }
}
