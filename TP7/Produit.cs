using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TP7
{
    public abstract class Produit
    {
        private String name;
        private double purchase_price;
        private double price_not_member;
        private double price_member;

        public Produit(String name, double purchase_price , double price_not_member, double price_member)
        {
            this.name = name;
            this.price_not_member = price_not_member;
            this.price_member = price_member;
            this.purchase_price = purchase_price;
        }

        public String Name { get; }
        public double Purchase_price { get; }
        public double Price_not_member { get; }
        public double Price_member { get; }

    }
}
