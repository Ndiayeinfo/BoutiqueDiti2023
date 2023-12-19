using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceReport.Model
{
    public class ProduitModel
    {
        public string NomProduit {  get; set; }
        public string CategorieProduit { get; set; }

        public float Quantite { get; set;}
        public double PrixUnitaire { get; set;}

        public DateTime DatePeremption { get; set;}
    }
}