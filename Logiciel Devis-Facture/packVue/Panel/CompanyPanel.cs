using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture.packVue.Panel
{
    class CompanyPanel : AbstractPanel, PanelTool
    {
        private SearchBar name;
        private SearchBar address;
        private SearchBar phone;
        private SearchBar mail;
        private SearchBar website;
        private SearchBar logo;
        private Label titleLabel;
        private Label nameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Label mailLabel;
        private Label websiteLabel;
        private Label logoLabel;
        private myButton logoButton;
        private myButton saveButton;
        private myButton cancelButton;

        public CompanyPanel()
        {
            name = new SearchBar();
            address = new SearchBar();
            phone = new SearchBar();
            mail = new SearchBar();
            website = new SearchBar();
            logo = new SearchBar();

            titleLabel = new Label();
            titleLabel.Text = "Modifier les informations de mon entreprise: ";
            nameLabel = new Label();
            nameLabel.Text = "Nom :";
            addressLabel = new Label();
            addressLabel.Text = "Adresse postale :";
            phoneLabel = new Label();
            phoneLabel.Text = "Téléphone :";
            mailLabel = new Label();
            mailLabel.Text = "Adresse Mail :";
            websiteLabel = new Label();
            websiteLabel.Text = "Site web :";
            logoLabel = new Label();
            logoLabel.Text = "Logo :";
            logo.Enabled = false;

            logoButton = new myButton();
            saveButton = new myButton();
            cancelButton = new myButton();

            this.Controls.Add(name);
            this.Controls.Add(address);
            this.Controls.Add(phone);
            this.Controls.Add(mail);
            this.Controls.Add(website);
            this.Controls.Add(logo);
            this.Controls.Add(titleLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(mailLabel);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(logoLabel);
            this.Controls.Add(logoButton);
            this.Controls.Add(saveButton);
            this.Controls.Add(cancelButton);

            logoButton.Click += new System.EventHandler(LogoButton_Click);
            saveButton.Click += new System.EventHandler();
            cancelButton.Click += new System.EventHandler();
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            int elementHeight = this.Height / 6;
            int elementWidth = this.Width / 2;
            int fontHeight = this.Height / 30;
            name.SetFontSize(0, elementHeight);
            name.SetSize(elementWidth,0);
            address.SetFontSize(0, elementHeight);
            address.SetSize(elementWidth, 0);
            phone.SetFontSize(0, elementHeight);
            phone.SetSize(elementWidth, 0);
            mail.SetFontSize(0, elementHeight);
            mail.SetSize(elementWidth, 0);
            website.SetFontSize(0, elementHeight);
            website.SetSize(elementWidth, 0);
            logo.SetFontSize(0, elementHeight); 
            logo.SetSize(elementWidth*3/4, 0);
            titleLabel.Font = new Font("Arial", fontHeight, FontStyle.Bold);
            titleLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            nameLabel.AutoSize = true;
            addressLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            addressLabel.AutoSize = true;
            phoneLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            phoneLabel.AutoSize = true;
            mailLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            mailLabel.AutoSize = true;
            websiteLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            websiteLabel.AutoSize = true;
            logoLabel.Font = new Font("Arial", fontHeight, FontStyle.Regular);
            logoLabel.AutoSize = true;
            logoButton.SetSize(elementWidth/ 4, logoLabel.Height);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            int barHeight = name.Height;
            int barWidth = name.Width;
            titleLabel.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 4,y/4);
            name.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y);
            nameLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
            address.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y + 2* barHeight);
            addressLabel.Location = new System.Drawing.Point(address.Location.X - addressLabel.Width, y + 2* barHeight);
            phone.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y + 4* barHeight);
            phoneLabel.Location = new System.Drawing.Point(phone.Location.X - phoneLabel.Width, y + 4* barHeight);
            mail.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y + 6 * barHeight);
            mailLabel.Location = new System.Drawing.Point(mail.Location.X - mailLabel.Width, y + 6 * barHeight);
            website.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y + 8 * barHeight);
            websiteLabel.Location = new System.Drawing.Point(website.Location.X - websiteLabel.Width, y + 8 * barHeight);
            logo.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y + 10 * barHeight);
            logoLabel.Location = new System.Drawing.Point(logo.Location.X - logoLabel.Width, y + 10 * barHeight);
            logoButton.Location = new System.Drawing.Point(logo.Location.X + logo.Width, y + 10 * barHeight);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int buttonWidth, int buttonHeight)
        {
            throw new NotImplementedException();
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Logo(*JPG,*PNG) | *JPG;*PNG";
            file.Title = "Selectionner un logo";
            DialogResult resultat = file.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                try
                {
                    string fileName = file.FileName;
                    logo.Text = file.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
