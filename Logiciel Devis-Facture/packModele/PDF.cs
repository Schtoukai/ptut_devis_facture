using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture.packModele
{
    class PDF
    {
        private String name;
        private int numero;
        private String date;

        public PDF() {}

        public PDF(String name, int numero, String date)
        {
            this.name = name;
            this.numero = numero;
            this.date = date;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getDate()
        {
            return this.date;
        }

        /*public bool generatePDF()
        {
            //Si tous les champs ne sont pas remplis
            if (textBoxName.Text == "" || textBoxStreet.Text == "" || textBoxCity.Text == "" || textBoxPhone.Text == "" || textBoxMail.Text == "")
            {
                MessageBox.Show("Informations manquantes.");
                return false;
            }
            //S'ils sont remplis
            else
            {
                //Création du PDF
                Document invoice = new Document();
                PdfWriter writer = PdfWriter.GetInstance(invoice, new FileStream("C:/Users/julie/Desktop/Facture.pdf", FileMode.Create));
                invoice.Open();

                //Ajout du logo de l'entreprise
                Image i1 = Image.GetInstance("C:/Users/julie/Desktop/IUT Info/2A/ptut/PDFCreator/PDFCreator/images/logo.png");
                i1.ScaleAbsoluteWidth(141);
                i1.ScaleAbsoluteHeight(100);
                invoice.Add(i1);

                //On ajoute un espace entre le logo et l'info de l'entreprise
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 5f,
                    SpacingAfter = 0f,
                };
                invoice.Add(spacer);

                //Informations de l'entreprise
                PdfPTable companyInfo = new PdfPTable(1);
                PdfPCell companyName = new PdfPCell(new Paragraph("COMENCO"));
                companyName.Border = 0;
                companyInfo.AddCell(companyName);
                PdfPCell companyStreet = new PdfPCell(new Paragraph("78 rue Victor Hugo"));
                companyStreet.Border = 0;
                companyInfo.AddCell(companyStreet);
                PdfPCell companyCity = new PdfPCell(new Paragraph("69002 Lyon"));
                companyCity.Border = 0;
                companyInfo.AddCell(companyCity);
                PdfPCell companyPhone = new PdfPCell(new Paragraph("04 12 84 33 76"));
                companyPhone.Border = 0;
                companyInfo.AddCell(companyPhone);
                PdfPCell companyMail = new PdfPCell(new Paragraph("contact@comenco.com"));
                companyMail.Border = 0;
                companyInfo.AddCell(companyMail);
                PdfPCell companyWebsite = new PdfPCell(new Paragraph("www.comenco.fr"));
                companyWebsite.Border = 0;
                companyInfo.AddCell(companyWebsite);

                companyInfo.WidthPercentage = 30;
                companyInfo.HorizontalAlignment = Element.ALIGN_LEFT;

                invoice.Add(companyInfo);

                //Informations du client
                PdfPTable clientInfo = new PdfPTable(1);

                PdfPCell clientName = new PdfPCell(new Paragraph(textBoxName.Text));
                clientName.Border = 0;
                clientInfo.AddCell(clientName);

                PdfPCell clientStreet = new PdfPCell(new Paragraph(textBoxStreet.Text));
                clientStreet.Border = 0;
                clientInfo.AddCell(clientStreet);

                PdfPCell clientCity = new PdfPCell(new Paragraph(textBoxCity.Text));
                clientCity.Border = 0;
                clientInfo.AddCell(clientCity);

                PdfPCell clientPhone = new PdfPCell(new Paragraph(textBoxPhone.Text));
                clientPhone.Border = 0;
                clientInfo.AddCell(clientPhone);

                PdfPCell clientMail = new PdfPCell(new Paragraph(textBoxMail.Text));
                clientMail.Border = 0;
                clientInfo.AddCell(clientMail);

                PdfPTable clientCadre = new PdfPTable(1);
                clientCadre.AddCell(clientInfo);
                clientCadre.HorizontalAlignment = Element.ALIGN_RIGHT;
                clientCadre.WidthPercentage = 40;
                invoice.Add(clientCadre);

                //On valide le PDF
                invoice.Close();

                //Message de validation
                MessageBox.Show("Facture créée");
            }
            return true;
        }*/
    }
}
