using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class BoissonAlcoolisee : Produit
    {
        double alcoolDegree;

        public BoissonAlcoolisee(String name, double purchase_price, double price_not_member, double price_member, double alcoolDegree) : base(name, purchase_price, price_not_member, price_member)
        {
            this.alcoolDegree = alcoolDegree;
        }
    }
}
