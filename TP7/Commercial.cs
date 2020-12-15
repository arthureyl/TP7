using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class Commercial
    {

        public Produit CreateProduit(String name, double purchase_price, double price_not_member, double price_member, double alcoolDegree=0)
        {
            IProduit iprod = new AdapterProduit(name, purchase_price, price_not_member, price_member, alcoolDegree);
            return iprod.GenerateProduit();
        }

        public void CreerCommande(String productName, int nbProd)
        {
            BDE bde = BDE.Instance;
            Boolean pExists = bde.Stock.GetProduitByName(productName);
            if (pExists)
            {
                bde.Stock.ChangeStockValue(productName, nbProd);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
