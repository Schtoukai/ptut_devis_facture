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
            nameLabel.Font = new Font("Calibri", 18);
            nameLabel.BorderStyle = BorderStyle.FixedSingle;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Text = "Nom";
            addressLabel = new Label();
            addressLabel.Font = new Font("Calibri", 18);
            addressLabel.BorderStyle = BorderStyle.FixedSingle;
            addressLabel.TextAlign = ContentAlignment.MiddleCenter;
            addressLabel.Text = "Adresse";
            phoneLabel = new Label();
            phoneLabel.Font = new Font("Calibri", 18);
            phoneLabel.BorderStyle = BorderStyle.FixedSingle;
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            phoneLabel.Text = "Téléphone";
            mailLabel = new Label();
            mailLabel.Font = new Font("Calibri", 18);
            mailLabel.BorderStyle = BorderStyle.FixedSingle;
            mailLabel.TextAlign = ContentAlignment.MiddleCenter;
            mailLabel.Text = "Email";
            websiteLabel = new Label();
            websiteLabel.Font = new Font("Calibri", 18);
            websiteLabel.BorderStyle = BorderStyle.FixedSingle;
            websiteLabel.TextAlign = ContentAlignment.MiddleCenter;
            websiteLabel.Text = "Site web";
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
            //this.BackColor = Color.Red;
            /*name.BackColor = Color.Purple;
            address.BackColor = Color.Purple;
            phone.BackColor = Color.Purple;
            mail.BackColor = Color.Purple;
            website.BackColor = Color.Purple;*/
            nameLabel.ForeColor = Color.Blue;
            addressLabel.ForeColor = Color.Blue;
            phoneLabel.ForeColor = Color.Blue;
            mailLabel.ForeColor = Color.Blue;
            websiteLabel.ForeColor = Color.Blue;
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width * 3 / 4, height * 3 / 4);
            name.SetSize(this.Width * 2 / 5, 0);
            address.SetSize(this.Width * 2 / 5, 0);
            phone.SetSize(this.Width * 2 / 5, 0);
            mail.SetSize(this.Width * 2 / 5, 0);
            website.SetSize(this.Width * 2 / 5, 0);
            nameLabel.Size = new System.Drawing.Size(this.Width / 20, 0);
            addressLabel.Size = new System.Drawing.Size(this.Width / 20, 0);
            phoneLabel.Size = new System.Drawing.Size(this.Width / 20, 0);
            mailLabel.Size = new System.Drawing.Size(this.Width / 20, 0);
            websiteLabel.Size = new System.Drawing.Size(this.Width / 20, 0);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            name.Location = new System.Drawing.Point((this.Size.Width - name.Width) / 2, y);
            nameLabel.Location = new System.Drawing.Point(name.Location.X-nameLabel.Width, y);
            address.Location = new System.Drawing.Point(name.Location.X,name.Location.Y+2*name.Size.Height);
            addressLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
            phone.Location = new System.Drawing.Point(name.Location.X, address.Location.Y + 2 * name.Size.Height);
            phoneLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
            mail.Location = new System.Drawing.Point(name.Location.X, phone.Location.Y + 2 * name.Size.Height);
            mailLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
            website.Location = new System.Drawing.Point(name.Location.X, mail.Location.Y + 2 * name.Size.Height);
            websiteLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }
    }
}
