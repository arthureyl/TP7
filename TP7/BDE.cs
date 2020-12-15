using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public sealed class BDE
    {
        private Stock _stock;
        private Dictionary<Client,int> _students;
        private static BDE singleton = null;

        private BDE()
        {
        }

        public void AddStudent(Client stud, int income)
        {
            _students.Add(stud, income);
        }

        public static BDE Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new BDE();
                }
                else
                {
                    Console.WriteLine("BDE already exists");
                }

                return singleton;
            }
            
        }

    public List<Client> HavingNegativeIncome(int val_min = 0)
        {
            List<Client> stud_neg = new List<Client>();
            foreach(var student in _students.Keys)
            {
                if (this._students[student] < val_min)
                {
                    stud_neg.Add(student);
                }
            }

            return stud_neg;
        }

        public void ShowCLients(List<Client> clients)
        {
            foreach(var client in clients)
            {
                Console.WriteLine(client.Firstname + " " + client.Lastname);
            }
        }
        public Stock Stock { get; set; }
        public int Students { get; set; }
        public BDE Singleton { get; set; }
    }
}
