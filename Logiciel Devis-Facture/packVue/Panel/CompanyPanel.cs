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
        public const double PointToEm = 15*0.083333334163205;
        private SearchBar name;
        private SearchBar address;
        private SearchBar phone;
        private SearchBar mail;
        private SearchBar website;
        private SearchBar logo;
        private SearchBar siret;
        private Label titleLabel;
        private Label nameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Label mailLabel;
        private Label websiteLabel;
        private Label logoLabel;
        private Label siretLabel;
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
            siret = new SearchBar();

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
            siretLabel = new Label();
            siretLabel.Text = "SIRET :";

            logoButton = new myButton();
            saveButton = new myButton();
            saveButton.Text = "Sauvegarder ?";
            saveButton.Enabled = false;
            saveButton.BackColor = Color.Empty;
            Console.WriteLine("Color " + saveButton.BackColor);
            cancelButton = new myButton();
            cancelButton.Text = "Effacer";
            cancelButton.Enabled = false;
            cancelButton.BackColor = Color.Empty;

            this.Controls.Add(name);
            this.Controls.Add(address);
            this.Controls.Add(phone);
            this.Controls.Add(mail);
            this.Controls.Add(website);
            this.Controls.Add(siret);
            this.Controls.Add(logo);
            this.Controls.Add(titleLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(mailLabel);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(siretLabel);
            this.Controls.Add(logoLabel);
            this.Controls.Add(logoButton);
            this.Controls.Add(saveButton);
            this.Controls.Add(cancelButton);

            logoButton.Click += new System.EventHandler(LogoButton_Click);
            saveButton.Click += new System.EventHandler(SaveButton_Click);
            cancelButton.Click += new System.EventHandler(CancelButton_Click);
        }

        public override void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
            int fontHeight = this.Height/45;
            int elementWidth = this.Width/2;
            name.SetFontSize(fontHeight);
            name.SetSize(elementWidth,0);
            name.TextChanged += new System.EventHandler(TextField_TextChanged);
            address.SetFontSize(fontHeight);
            address.SetSize(elementWidth, 0);
            address.TextChanged += new System.EventHandler(TextField_TextChanged);
            phone.SetFontSize(fontHeight);
            phone.SetSize(elementWidth, 0);
            phone.TextChanged += new System.EventHandler(TextField_TextChanged);
            mail.SetFontSize(fontHeight);
            mail.SetSize(elementWidth, 0);
            mail.TextChanged += new System.EventHandler(TextField_TextChanged);
            website.SetFontSize(fontHeight);
            website.SetSize(elementWidth, 0);
            website.TextChanged += new System.EventHandler(TextField_TextChanged);
            siret.SetFontSize(fontHeight);
            siret.SetSize(elementWidth, 0);
            siret.TextChanged += new System.EventHandler(TextField_TextChanged);
            logo.SetFontSize(fontHeight); 
            logo.SetSize(elementWidth*3/4, 0);
            logo.TextChanged += new System.EventHandler(TextField_TextChanged);
            titleLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Bold);
            titleLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            nameLabel.AutoSize = true;
            addressLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            addressLabel.AutoSize = true;
            phoneLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            phoneLabel.AutoSize = true;
            mailLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            mailLabel.AutoSize = true;
            websiteLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            websiteLabel.AutoSize = true;
            siretLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            siretLabel.AutoSize = true;
            logoLabel.Font = new Font("Arial", (float)(fontHeight * PointToEm), FontStyle.Regular);
            logoLabel.AutoSize = true;
            logoButton.SetSize(elementWidth/ 4, logoLabel.Height);
            saveButton.SetSize(elementWidth / 4, 2*logoLabel.Height);
            cancelButton.SetSize(elementWidth / 4, 2*logoLabel.Height);
        }

        public override void SetLocation(int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            int barHeight = name.Height;
            int barWidth = name.Width;
            titleLabel.Location = new System.Drawing.Point((this.Size.Width - titleLabel.Width) / 2,0);
            name.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2);
            nameLabel.Location = new System.Drawing.Point(name.Location.X - nameLabel.Width, y/2);
            address.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2 + 2* barHeight);
            addressLabel.Location = new System.Drawing.Point(address.Location.X - addressLabel.Width, y/2 + 2* barHeight);
            phone.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2 + 4* barHeight);
            phoneLabel.Location = new System.Drawing.Point(phone.Location.X - phoneLabel.Width, y/2 + 4* barHeight);
            mail.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2 + 6 * barHeight);
            mailLabel.Location = new System.Drawing.Point(mail.Location.X - mailLabel.Width, y/2 + 6 * barHeight);
            website.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2 + 8 * barHeight);
            websiteLabel.Location = new System.Drawing.Point(website.Location.X - websiteLabel.Width, y/2 + 8 * barHeight);
            siret.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y / 2 + 10 * barHeight);
            siretLabel.Location = new System.Drawing.Point(siret.Location.X - siretLabel.Width, y / 2 + 10 * barHeight);
            logo.Location = new System.Drawing.Point((this.Size.Width - barWidth) / 2, y/2 + 12 * barHeight);
            logoLabel.Location = new System.Drawing.Point(logo.Location.X - logoLabel.Width, y/2 + 12 * barHeight);
            logoButton.Location = new System.Drawing.Point(logo.Location.X + logo.Width, y/2 + 12 * barHeight);
            saveButton.SetLocation(this.Size.Width/2 - 4*saveButton.Width/3, y/2 + 14 * barHeight);
            cancelButton.SetLocation(this.Size.Width/2 + cancelButton.Width/3, y/2 + 14 * barHeight);
        }

        public override void SetMargin(int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public override void SetFontSize(int size)
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
                    string filePath = file.FileName;
                    //string fileName = filePath.Substring(filePath.LastIndexOf('\'));
                    logo.Text = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            int sumOfText = name.Text.Length + address.Text.Length + phone.Text.Length + mail.Text.Length + website.Text.Length + siret.Text.Length +logo.Text.Length;
            
            if(sumOfText>0)
            {
                cancelButton.BackColor = Color.Red;
                cancelButton.Enabled = true;
            }
            else
            {
                cancelButton.BackColor = Color.Empty;
                cancelButton.Enabled = false;
            }

            if(!name.TextLength.Equals(0)&& !address.TextLength.Equals(0)&& !phone.TextLength.Equals(0)&& !mail.TextLength.Equals(0)&& !website.TextLength.Equals(0)&& !siret.TextLength.Equals(0)&& !logo.TextLength.Equals(0))
            {
                saveButton.BackColor = Color.Lime;
                saveButton.Enabled = true;
            }
            else 
            {
                saveButton.BackColor = Color.Empty;
                saveButton.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //
            //QueryDatabase
            //
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            name.ResetText();
            address.ResetText();
            phone.ResetText();
            mail.ResetText();
            website.ResetText();
            siret.ResetText();
            logo.ResetText();
            saveButton.BackColor = Color.Empty;
            saveButton.Enabled = false;
            cancelButton.BackColor = Color.Empty;
            cancelButton.Enabled = false;
        }
    }
}
