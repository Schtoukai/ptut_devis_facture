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
        private Label nameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Label mailLabel;
        private Label websiteLabel;
        private Label logoLabel;
        private OpenFileDialog file;

        public CompanyPanel()
        {
            name = new SearchBar();
            address = new SearchBar();
            phone = new SearchBar();
            mail = new SearchBar();
            website = new SearchBar();
            logo = new SearchBar();
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
            file = new OpenFileDialog();
            this.Controls.Add(name);
            this.Controls.Add(address);
            this.Controls.Add(phone);
            this.Controls.Add(mail);
            this.Controls.Add(website);
            this.Controls.Add(logo);
            this.Controls.Add(nameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(mailLabel);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(logoLabel);
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            int elementHeight = this.Height / 6;
            int fontHeight = this.Height / 30;
            name.SetFontSize(0, elementHeight);
            name.SetSize(this.Width /2,0);
            address.SetFontSize(0, elementHeight);
            address.SetSize(this.Width / 2, 0);
            phone.SetFontSize(0, elementHeight);
            phone.SetSize(this.Width / 2, 0);
            mail.SetFontSize(0, elementHeight);
            mail.SetSize(this.Width / 2, 0);
            website.SetFontSize(0, elementHeight);
            website.SetSize(this.Width / 2, 0);
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
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            name.Location = new System.Drawing.Point((this.Size.Width - name.Width) / 2, y);
            nameLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
            address.Location = new System.Drawing.Point((this.Size.Width - address.Width) / 2, y + 2*name.Height);
            addressLabel.Location = new System.Drawing.Point(address.Location.X - addressLabel.Width, y + 2*name.Height);
            phone.Location = new System.Drawing.Point((this.Size.Width - phone.Width) / 2, y + 4*name.Height);
            phoneLabel.Location = new System.Drawing.Point(phone.Location.X - phoneLabel.Width, y + 4*name.Height);
            mail.Location = new System.Drawing.Point((this.Size.Width - mail.Width) / 2, y + 6 * name.Height);
            mailLabel.Location = new System.Drawing.Point(mail.Location.X - mailLabel.Width, y + 6 * name.Height);
            website.Location = new System.Drawing.Point((this.Size.Width - website.Width) / 2, y + 8 * name.Height);
            websiteLabel.Location = new System.Drawing.Point(website.Location.X - websiteLabel.Width, y + 8 * name.Height);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int buttonWidth, int buttonHeight)
        {
            throw new NotImplementedException();
        }
    }
}
