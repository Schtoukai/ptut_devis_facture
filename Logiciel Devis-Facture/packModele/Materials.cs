using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_Devis_Facture.packModele
{
    public class Materials
    {
        private int idMateriel;
        private string nameMaterials;
        private float price;
        private float TVA;

        public Materials()
        {
            ;
        }

        public Materials(int _id, string _name, float _price, float _tva)
        {
            this.idMateriel = _id;
            this.nameMaterials = _name;
            this.price = _price;
            this.TVA = _tva;
        }

        public void setIdMateriel(int idMateriel)
        {
            this.idMateriel = idMateriel;
        }

        public int getIdMateriel()
        {
            return this.idMateriel;
        }

        public void setNameMaterials(string nameMaterials)
        {
            this.nameMaterials = nameMaterials;
        }

        public string getNameMaterials()
        {
            return this.nameMaterials;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public float getPrice()
        {
            return this.price;
        }

        public void setTVA(float TVA)
        {
            this.TVA = TVA;
        }

        public float getTVA()
        {
            return this.TVA;
        }
    }
}
