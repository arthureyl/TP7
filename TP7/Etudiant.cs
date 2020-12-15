using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TP7
{
    public class Etudiant : Client
    {
        int year_diploma;

        public Etudiant(String firstname, String lastname, int age, int year_diploma) : base(firstname, lastname,age)
        {
            this.year_diploma = year_diploma;
        }
    }
}
