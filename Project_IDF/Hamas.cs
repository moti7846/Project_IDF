using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF
{
    internal class Hamas
    {

        string Name = "Hamas";
        int Year = 1987;

        string Commander;
        public List<Trorist> Trorists_Data = new List<Trorist> ();

        public string get_Name()
        {
            return Name;
        }
     
        public void set_Name(string name)
        {
            Name = name;
        }
        public string get_Commander()
        {
            return Commander;
        }
        public void set_Commander(string Commander)
        {
            Name = Commander;
        }
        public void set_Trorist(string name,int rank)
        {
            Trorists_Data.Add(new Trorist(name, rank));
            Console.WriteLine();
        }
        public void get_Trorist()
        {
            foreach(var tror in Trorists_Data)
            {
                Console.WriteLine(tror.Name);
            }
        }

        public void get_weapaon(string name)
        {
            foreach (var tror in Trorists_Data)
            {
                if(tror.Name == name)
                {
                    Console.WriteLine("_________________-");
                    Console.WriteLine(tror.Name);
                    tror.get_weapaon();
                }
            }
        }
        public void Set_weapaon(string name, string weapaon)
        {
            foreach (var tror in Trorists_Data)
            {
                if(tror.Name == name)
                {
                    tror.add_weapaon(weapaon);
                }
            }
        }
    }
}
