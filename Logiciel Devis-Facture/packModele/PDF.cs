using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
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

        public bool generatePDF(TextBox textBoxName, TextBox textBoxStreet, TextBox textBoxCity, TextBox textBoxPhone, TextBox textBoxMail, DataGridView itemGrid)
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
                Document pdf = new Document();
                String pdfName = "myPDF.pdf";
                PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(pdfName, FileMode.Create));
                pdf.Open();

                //Ajout du logo de l'entreprise
                /*Image i1 = Image.GetInstance("C:/Users/julie/Desktop/IUT Info/2A/ptut/PDFCreator/PDFCreator/images/logo.png");
                i1.ScaleAbsoluteWidth(141);
                i1.ScaleAbsoluteHeight(100);
                pdf.Add(i1);*/

                //On ajoute un espace entre le logo et l'info de l'entreprise
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 5f,
                    SpacingAfter = 0f,
                };
                pdf.Add(spacer);

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

                pdf.Add(companyInfo);

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
                pdf.Add(clientCadre);

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(itemGrid.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in itemGrid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in itemGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        catch { }
                    }
                }

                //Pour que le tableau prenne toute la largeur de la page 
                pdfTable.WidthPercentage = 100;

                pdf.Add(pdfTable);

                //On valide le PDF
                pdf.Close();

                //On ouvre le PDF
                Process.Start(pdfName);
            }
            return true;
        }
    }
}
