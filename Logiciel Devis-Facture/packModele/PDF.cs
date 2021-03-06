﻿using iTextSharp.text;
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

        public PDF() { }

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

        public bool generatePDF(Company entreprise, Create_PDF form) {
            string pdfName = "myPDF.pdf";
            //Si tous les champs ne sont pas remplis
            if (form.getTextBoxName().Text == "" || form.getTextBoxStreet().Text == "" || form.getTextBoxZip().Text == "" || form.getTextBoxCity().Text == "" || form.getTextBoxPhone().Text == "" || form.getTextBoxMail().Text == "" || form.getItemGrid().Rows.Count == 0)
            {
                MessageBox.Show("Informations manquantes.");
                return false;
            }
            if (form.getIsInvoiceButton().Checked == false && form.getIsQuoteButton().Checked == false)
            {
                MessageBox.Show("Veuillez sélectionner un type de document.");
                return false;
            }
            //S'ils sont remplis
            else
            {
                //Création du PDF
                Document pdf = new Document();
                PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(pdfName, FileMode.Create));
                pdf.Open();

                PdfPTable header = new PdfPTable(2);
                header.HorizontalAlignment = Element.ALIGN_LEFT;
                header.WidthPercentage = 100;
                header.SetWidths(new float[] { 45, 55 });

                //Ajout du logo de l'entreprise
                if (entreprise.getCompLogo().getPathing() != null)
                {
                    Image logo = Image.GetInstance(Directory.GetCurrentDirectory() + "\\Logo\\" + entreprise.getCompLogo().getName() + entreprise.getCompLogo().getFormat());
                    float scalePercent = (((pdf.PageSize.Width / logo.Width) * 100) - 80);
                    logo.ScalePercent(scalePercent);
                    PdfPCell logoCell = new PdfPCell(logo);
                    logoCell.Border = 0;
                    logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    header.AddCell(logoCell);
                }

                //On initialise un spacer
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 5f,
                    SpacingAfter = 10f,
                };

                //Informations du client
                PdfPTable clientInfo = new PdfPTable(1);

                PdfPCell clientName = new PdfPCell(new Paragraph(form.getTextBoxName().Text));
                clientName.Border = 0;
                clientInfo.AddCell(clientName);

                PdfPCell clientStreet = new PdfPCell(new Paragraph(form.getTextBoxStreet().Text));
                clientStreet.Border = 0;
                clientInfo.AddCell(clientStreet);

                if (form.getTextBoxAdditionnalAddress().Text != "")
                {
                    PdfPCell additionnalAddress = new PdfPCell(new Paragraph(form.getTextBoxAdditionnalAddress().Text));
                    additionnalAddress.Border = 0;
                    clientInfo.AddCell(additionnalAddress);
                }

                PdfPCell zipAndCity = new PdfPCell(new Paragraph(form.getTextBoxZip().Text + ", " + form.getTextBoxCity().Text));
                zipAndCity.Border = 0;
                clientInfo.AddCell(zipAndCity);

                PdfPCell clientPhone = new PdfPCell(new Paragraph(form.getTextBoxPhone().Text));
                clientPhone.Border = 0;
                clientInfo.AddCell(clientPhone);

                PdfPCell clientMail = new PdfPCell(new Paragraph(form.getTextBoxMail().Text));
                clientMail.Border = 0;
                clientInfo.AddCell(clientMail);

                PdfPTable clientCadre = new PdfPTable(1);
                clientCadre.AddCell(clientInfo);
                clientCadre.HorizontalAlignment = Element.ALIGN_RIGHT;
                clientCadre.WidthPercentage = 45;

                PdfPCell voidCell = new PdfPCell();
                voidCell.Border = 0;

                //Informations de l'entreprise
                PdfPTable companyInfo = new PdfPTable(1);

                PdfPCell companyName = new PdfPCell(new Paragraph(entreprise.getCompanyName()));
                companyName.Border = 0;
                companyInfo.AddCell(companyName);

                PdfPCell companyStreet = new PdfPCell(new Paragraph(entreprise.getStreet()));
                companyStreet.Border = 0;
                companyInfo.AddCell(companyStreet);

                if (entreprise.getAdditionnal() != null)
                {
                    PdfPCell companyAdditionnal = new PdfPCell(new Paragraph(entreprise.getAdditionnal()));
                    companyAdditionnal.Border = 0;
                    companyInfo.AddCell(companyAdditionnal);
                }

                PdfPCell companyCity = new PdfPCell(new Paragraph(entreprise.getZip() + ", " + entreprise.getCity()));
                companyCity.Border = 0;
                companyInfo.AddCell(companyCity);

                string tel = entreprise.getPhone();
                if (tel != null && tel.Length == 10)
                {
                    tel = entreprise.getPhone().Insert(2, " ").Insert(5, " ").Insert(8, " ").Insert(11, " ");
                }
                PdfPCell companyPhone = new PdfPCell(new Paragraph(tel));
                companyPhone.Border = 0;
                companyInfo.AddCell(companyPhone);

                PdfPCell companyMail = new PdfPCell(new Paragraph(entreprise.getMail()));
                companyMail.Border = 0;
                companyInfo.AddCell(companyMail);

                PdfPCell companyWebsite = new PdfPCell(new Paragraph(entreprise.getWebsite()));
                companyWebsite.Border = 0;
                companyInfo.AddCell(companyWebsite);

                PdfPCell companyInfoCell = new PdfPCell(companyInfo);
                companyInfoCell.Border = 0;

                header.AddCell(voidCell);
                header.AddCell(companyInfoCell);
                header.AddCell(clientInfo);

                pdf.Add(header);

                //Spacer
                pdf.Add(spacer);

                //Numéro et date du document
                PdfPTable numAndDate = new PdfPTable(2);

                PdfPCell numCell = new PdfPCell(new Paragraph("N° : " + form.getTextBoxNumero().Text));
                numCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                numCell.Border = 0;
                numAndDate.AddCell(numCell);

                PdfPCell dateCell = new PdfPCell(new Paragraph("Date : " + form.getTextBoxDateTimePicker().Value.ToShortDateString()));
                dateCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                dateCell.Border = 0;
                numAndDate.AddCell(dateCell);

                numAndDate.WidthPercentage = 100;
                pdf.Add(numAndDate);

                //Spacer
                pdf.Add(spacer);

                //Ajout de "FACTURE" ou de "DEVIS" au dessus du tableau
                PdfPTable docNature = new PdfPTable(1);
                docNature.WidthPercentage = 100;
                Chunk c;
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font font = new Font(bf, 15, Font.NORMAL);

                if (form.getIsInvoiceButton().Checked == true)
                {
                    c = new Chunk("FACTURE", font);
                }
                else
                {
                    c = new Chunk("DEVIS", font);
                }
                Paragraph p = new Paragraph(c);
                PdfPCell cellule = new PdfPCell(p);
                cellule.HorizontalAlignment = Element.ALIGN_CENTER;
                cellule.VerticalAlignment = Element.ALIGN_TOP;
                cellule.BackgroundColor = new BaseColor(181, 214, 255);
                cellule.Border = 0;
                docNature.AddCell(cellule);
                pdf.Add(docNature);

                //Grille du PDF
                PdfPTable pdfTable = new PdfPTable(form.getItemGrid().ColumnCount);
                pdfTable.SetWidths(new float[] { 50, 15, 10, 10, 15 });
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Ajout de la ligne entête
                foreach (DataGridViewColumn column in form.getItemGrid().Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    BaseColor cellBg = new BaseColor(185, 185, 185); //Gris clair
                    cell.BackgroundColor = cellBg;
                    pdfTable.AddCell(cell);
                }

                //Ajout des lignes de données
                foreach (DataGridViewRow row in form.getItemGrid().Rows)
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

                pdf.Add(spacer);
                pdf.Add(spacer);

                //Partie récapitulative
                PdfPTable recap = new PdfPTable(2);
                recap.WidthPercentage = 100;
                recap.SetWidths(new float[] { 60, 40 });

                PdfPTable conditionRecap = new PdfPTable(1);

                if (form.getIsInvoiceButton().Checked == true)
                {
                    PdfPCell deadline = new PdfPCell(new Paragraph("Facture à régler avant le : " + form.getTextBoxDateTimePicker().Value.AddMonths(1).ToShortDateString()));
                    deadline.Border = 0;
                    conditionRecap.AddCell(deadline);
                }
                else
                {
                    PdfPCell validTime = new PdfPCell(new Paragraph("Durée de validité du devis : 30 jours"));
                    validTime.Border = 0;
                    conditionRecap.AddCell(validTime);
                }

                PdfPCell acompte = new PdfPCell(new Paragraph("Acompte à verser lors de la commande : 30%"));
                acompte.Border = 0;
                conditionRecap.AddCell(acompte);

                PdfPCell solde = new PdfPCell(new Paragraph("Solde : au début des travaux"));
                solde.Border = 0;
                conditionRecap.AddCell(solde);

                PdfPCell payement = new PdfPCell(new Paragraph("Mode de paiement : Chèque - Virement"));
                payement.Border = 0;
                conditionRecap.AddCell(payement);

                conditionRecap.AddCell(voidCell);

                recap.AddCell(conditionRecap);

                PdfPTable tabRecap = new PdfPTable(2);
                tabRecap.WidthPercentage = 40;
                tabRecap.HorizontalAlignment = Element.ALIGN_RIGHT;

                PdfPCell sousTotalLabel = new PdfPCell(new Paragraph("Sous-Total"));
                tabRecap.AddCell(sousTotalLabel);
                PdfPCell sousTotalValue = new PdfPCell(new Paragraph(form.getSousTotal().ToString() + "€"));
                tabRecap.AddCell(sousTotalValue);

                if(form.getAmountButton().Checked == true)
                {
                    PdfPCell remiseLabel = new PdfPCell(new Paragraph("Remise (€)"));
                    tabRecap.AddCell(remiseLabel);
                    PdfPCell remiseValue = new PdfPCell(new Paragraph(form.getTextBoxPromo().Text + "€"));
                    tabRecap.AddCell(remiseValue);
                }
                else
                {
                    PdfPCell remiseLabel = new PdfPCell(new Paragraph("Remise" + " (" + form.getTextBoxPromo().Text + "%)"));
                    tabRecap.AddCell(remiseLabel);
                    PdfPCell remiseValue = new PdfPCell(new Paragraph((form.getSousTotal() * float.Parse(form.getTextBoxPromo().Text) / 100).ToString() + "€"));
                    tabRecap.AddCell(remiseValue);
                }

                PdfPCell totalHTLabel = new PdfPCell(new Paragraph("Total Facture HT"));
                tabRecap.AddCell(totalHTLabel);
                PdfPCell totalHTValue = new PdfPCell(new Paragraph(form.getTextBoxHTTotal().Text + "€"));
                tabRecap.AddCell(totalHTValue);

                PdfPCell totalTVALabel = new PdfPCell(new Paragraph("Total TVA"));
                tabRecap.AddCell(totalTVALabel);
                PdfPCell totalTVAValue = new PdfPCell(new Paragraph(form.getTotalTVA()));
                tabRecap.AddCell(totalTVAValue);

                PdfPCell totalTTCLabel = new PdfPCell(new Paragraph("Total TTC"));
                tabRecap.AddCell(totalTTCLabel);
                PdfPCell totalTTCValue = new PdfPCell(new Paragraph(form.getTextBoxTTCTotal().Text + "€"));
                tabRecap.AddCell(totalTTCValue);

                PdfPCell cellTabRecap = new PdfPCell(tabRecap);
                cellTabRecap.Border = 0;
                recap.AddCell(cellTabRecap);

                pdf.Add(recap);
                pdf.Add(spacer);
                //Phrase de fin
                if (form.getIsInvoiceButton().Checked == true)
                {
                    Paragraph endPhrase = new Paragraph("En votre aimable règlement de cette facture");
                    pdf.Add(endPhrase);
                }
                else
                {
                    Paragraph endPhrase = new Paragraph("En votre aimable acceptation de ce devis");
                    pdf.Add(endPhrase);
                }

                pdf.Add(spacer);
                pdf.Add(spacer);
                pdf.Add(spacer);
                pdf.Add(spacer);

                //Mentions légales
                PdfPTable footer = new PdfPTable(1);
                footer.WidthPercentage = 100;

                PdfPCell tiret = new PdfPCell(new Paragraph("---------------------------------------------------------------------------------------------------------------------------------"));
                tiret.Border = 0;
                footer.AddCell(tiret);
                Paragraph mentions = new Paragraph(new Chunk("SASU au Capital de 45 000€ - Siret " + entreprise.getSiret() + " - RCS 8425656950 - Code APE 4933C - N° de TVA intracommunotaire FR845123632147 " +
                "Assurance professionnelle AXELLIANCE - La couverture géographique du contrat ou de la garantie (Article 22-2 de la loi n°96-603 du juillet 1996). Nous vous rappelons que toute somme " +
                "non payées à sa date d'exigibilité produira de plein droit des intérêts de retard équivalents au triple du taux d'intérêts légal de l'année en cours ainsi que le paiement d'une somme" +
                " de 40€ due au titre des frais de recouvrement."));
                mentions.Font = FontFactory.GetFont("Calibri", 7);
                PdfPCell mentionsCell = new PdfPCell(mentions);
                mentionsCell.Border = 0;
                footer.AddCell(mentionsCell);
                pdf.Add(footer);
                //On valide le PDF
                pdf.Close();

                //On ouvre le PDF
                System.Diagnostics.Process.Start(pdfName);
            }
            return true;
        }
    }
}
