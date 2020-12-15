using System;
using TP7;
using Xunit;

namespace XUnitTestProjectTP7
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Boisson b1 = new Boisson("Coca", 0.50, 1.50, 0.90);
            Boisson b2 = new Boisson("Orangina", 0.50, 1.50, 0.90);
            Boisson b3 = new Boisson("Eau petillante", 0.50, 1.50, 0.90);

            Nourriture n1 = new Nourriture("Chips", 0.50, 1.50, 0.90);
            Nourriture n2 = new Nourriture("Mars", 0.50, 1.50, 0.90);
            Nourriture n3 = new Nourriture("Sandwich", 0.50, 1.50, 0.90);

            BoissonAlcoolisee ba3 = new BoissonAlcoolisee("Biere", 0.50, 1.50, 0.90,5.6);

            Etudiant e1 = new Etudiant("Jean", "Test", 23,2020);
            Etudiant e2 = new Etudiant("Jean", "Test2", 17,2018);
            AutreClient prof = new AutreClient("Jean", "Prod", 52);
            AutreClient child = new AutreClient("Jean", "Prod", 5);

            Assert.False(child.CanBuy(ba3));
            Assert.True(child.CanBuy(n1));
            Assert.True(prof.CanBuy(ba3));
            Assert.True(prof.CanBuy(n2));
            Assert.True(e1.CanBuy(ba3));
            Assert.False(e2.CanBuy(ba3));
            Assert.True(e1.CanBuy(b3));

            Commercial com = new Commercial();
            Produit p1 = com.CreateProduit("eau", 0.50, 1.50, 0.90);
            Produit p2 = com.CreateProduit("chips", 0.50, 1.50, 0.90);
            Produit p3 = com.CreateProduit("biere", 0.50, 1.50, 0.90,6);

            Assert.IsType<Boisson>(p1);
            Assert.IsType<Nourriture>(p2);
            Assert.IsType<BoissonAlcoolisee>(p3);
            Assert.IsNotType<Boisson>(p3);


        }
    }
}
