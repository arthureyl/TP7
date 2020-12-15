using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TP7
{
    public class Stock
    {
        private Dictionary<Produit,int> stock_produit;

        public Stock(Produit prod, int nb_stock)
        {
            stock_produit = new Dictionary<Produit, int>();
            stock_produit.Add(prod,(nb_stock));
        }

        public Boolean GetProduitByName(String name_produit)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetStockProduitByName(String name_produit)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    return this.stock_produit[prod];
                }
            }

            return 0;
        }

        public Boolean ChangeStockValue(String name_produit, int stock_mvt)
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                if (prod.Name.Equals(name_produit))
                {
                    if(this.stock_produit[prod]+stock_mvt > 0)
                    {
                        this.stock_produit[prod] += stock_mvt;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }


        public void AddProduitInStock(Produit prod, int nb_stock)
        {
            stock_produit.Add(prod, nb_stock);
        }

        public void ShowFullStock()
        {
            foreach (var prod in this.stock_produit.Keys)
            {
                Console.WriteLine(prod.Name + " : " + this.stock_produit[prod]);
            }
        }
    }
}
