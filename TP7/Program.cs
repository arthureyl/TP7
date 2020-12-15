using System;
using System.Collections.Generic;
using System.IO;

namespace TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoadJson(@"C:\Users\Shadow\source\repos\TP3\TP3\etudiant.json");
        }

        public static void LoadJson(String path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
                //List<Etudiant> items = JsonConvert.DeserializeObject<List<Etudiant>>(json);
            }
        }
    }



}
