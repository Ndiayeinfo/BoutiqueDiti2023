using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiceMetier.Model;
using ServiceMetier.Utils;

namespace ServiceMetier
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        bdDiti2023Entities db = new bdDiti2023Entities();
        public List<Produits> getListeProduit()
        {
            return db.Produits.ToList();
        }

        public bool AddProduit(Produits produit)
        {
            try
            {
                db.Produits.Add(produit);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Helpers.WriteLogSystem(ex.ToString(), "AddProduit-Service");
                return false;
            }
        }
    }
}
