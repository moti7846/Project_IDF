using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF
{
    internal class Trorist : Hamas
    {
        public string Name;
        int Rank;
        string Status;
        List<string> Weapaon = new List<string> ();

        public Trorist(string name , int rank)
        {
            Name = name;
            Rank = rank;
            Status = "life";
        }

        public void add_weapaon(string weapaon)
        {
            Weapaon.Add(weapaon);
        }

        public void get_weapaon()
        {
            foreach(string item in Weapaon)
            {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine("_________________-");
        }
    }
}
