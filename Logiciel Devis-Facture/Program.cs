using Logiciel_Devis_Facture.packModele;
using System;
using System.Windows.Forms;

namespace Logiciel_Devis_Facture
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logiciel_Devis_Facture());
        }
    }
}
