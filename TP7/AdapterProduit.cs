using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class AdapterProduit : IProduit
    {
        private double _alcoolDegree;
        private String _name;
        private double _purchase_price;
        private double _price_not_member;
        private double _price_member;
        public AdapterProduit(String name, double purchase_price, double price_not_member, double price_member, double alcoolDegree)
        {
            AlcoolDegree = alcoolDegree;
            Name = name;
            Purchase_price = purchase_price;
            Price_not_member = price_member;
            Price_member = price_member;
        }
        public Produit GenerateProduit()
        {
            switch (Name.ToLower())
            {
                case "eau":
                    return new Boisson(Name, Purchase_price, Price_member, Price_not_member);
                case "chips":
                    return new Nourriture(Name, Purchase_price, Price_member, Price_not_member);
                case "biere":
                    return new BoissonAlcoolisee(Name, Purchase_price, Price_member, Price_not_member,AlcoolDegree); ;
                default:
                    throw new NotImplementedException();
            }
        }

        public double AlcoolDegree { get; set; }
        public String Name { get; set; }
        public double Purchase_price { get; set; }
        public double Price_not_member { get; set; }
        public double Price_member { get; set; }

    }
}
