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
        private Label nameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Label mailLabel;
        private Label websiteLabel;

        public CompanyPanel()
        {
            name = new SearchBar();
            address = new SearchBar();
            phone = new SearchBar();
            mail = new SearchBar();
            website = new SearchBar();
            nameLabel = new Label();
            nameLabel.Text = "Nom";
            addressLabel = new Label();
            addressLabel.Text = "Adresse";
            phoneLabel = new Label();
            phoneLabel.Text = "Téléphone";
            mailLabel = new Label();
            mailLabel.Text = "Email";
            websiteLabel = new Label();
            websiteLabel.Text = "Site web";
            /*nameLabel.AutoSize = true;
            addressLabel.AutoSize = true;
            phoneLabel.AutoSize = true;
            mailLabel.AutoSize = true;
            websiteLabel.AutoSize = true;*/
            this.Controls.Add(name);
            this.Controls.Add(address);
            this.Controls.Add(phone);
            this.Controls.Add(mail);
            this.Controls.Add(website);
            this.Controls.Add(nameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(mailLabel);
            this.Controls.Add(websiteLabel);
            this.nameLabel.BackColor = Color.Blue;
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            name.SetFontSize(0, this.Height/10);
            name.SetSize(this.Width * 2 / 5,0);
            address.SetFontSize(0, this.Height / 10);
            address.SetSize(this.Width * 2 / 5, 0);
            phone.SetFontSize(0, this.Height / 10);
            phone.SetSize(this.Width * 2 / 5, 0);
            mail.SetFontSize(0, this.Height / 10);
            mail.SetSize(this.Width * 2 / 5, 0);
            website.SetFontSize(0, this.Height / 10);
            website.SetSize(this.Width * 2 / 5, 0);
            nameLabel.Size = new System.Drawing.Size(200, this.Height/10);
            nameLabel.Font = new Font("Arial", 20,FontStyle.Regular);
            addressLabel.Size = new System.Drawing.Size(200, this.Height / 10);
            addressLabel.Font = new Font("Arial", 20, FontStyle.Regular);
            phoneLabel.Size = new System.Drawing.Size(200, this.Height / 10);
            phoneLabel.Font = new Font("Arial", 20, FontStyle.Regular);
            mailLabel.Size = new System.Drawing.Size(200, this.Height / 10);
            mailLabel.Font = new Font("Arial", 20, FontStyle.Regular);
            websiteLabel.Size = new System.Drawing.Size(200, this.Height / 10);
            websiteLabel.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            name.Location = new System.Drawing.Point((this.Size.Width - name.Width) / 2, y);
            nameLabel.Location = new System.Drawing.Point(nameLabel.Width, y);
            //address.Location = new System.Drawing.Point(name.Location.X,name.Location.Y+2*name.Size.Height);
            addressLabel.Location = new System.Drawing.Point(2*nameLabel.Width, y);
            //phone.Location = new System.Drawing.Point(name.Location.X, address.Location.Y + 2 * name.Size.Height);
            phoneLabel.Location = new System.Drawing.Point(3*nameLabel.Width, y);
            //mail.Location = new System.Drawing.Point(name.Location.X, phone.Location.Y + 2 * name.Size.Height);
            mailLabel.Location = new System.Drawing.Point(4*nameLabel.Width, y);
            //website.Location = new System.Drawing.Point(name.Location.X, mail.Location.Y + 2 * name.Size.Height);
            websiteLabel.Location = new System.Drawing.Point(5*nameLabel.Width, y);
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
