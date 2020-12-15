using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace TP7
{
    public abstract class Client
    {
        private String firstname;
        private String lastname;
        private int age;

        public String Firstname { get; }
        public String Lastname { get; }

        public int Age { get; set; }

        public Client(String firstname, String lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            FormatFirstname(this.firstname);
            FormatName(this.lastname);
        }

        private static void FormatFirstname(String n)
        {
            n = char.ToUpper(n[0]) + n.Substring(1);
        }
        
        private static void FormatName(String n)
        {
            n = n.ToUpper();
        }

        public String GetName()
        {

            return this.firstname + " " + lastname;
        }

        public Boolean CanBuy(Object obj)
        {
            if (obj.GetType() == typeof(BoissonAlcoolisee))
            {
                if(this.age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
