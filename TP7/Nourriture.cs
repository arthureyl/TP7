using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class Nourriture : Produit
    {
        public Nourriture(String name, double purchase_price, double price_not_member, double price_member) : base(name, purchase_price, price_not_member, price_member)
        {

        }
    }
}
