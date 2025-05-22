using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_IDF.IDF;

namespace project_IDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F_16CombatAircraft f1 = new F_16CombatAircraft();
            F_16CombatAircraft f2 = new F_16CombatAircraft();
            F_16CombatAircraft f3 = new F_16CombatAircraft();
            Artillery ar1 = new Artillery();

            Data_Idf data = new Data_Idf();
            data.AddNewWeapon(f3);
            data.AddNewWeapon(f1);
            data.AddNewWeapon(f2);
            data.AddNewWeapon(ar1);
            foreach(var item in data.Database.Values)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.Name + " " 
                        +item1.AmmoInventory);
                }

            }

            



        }
    }
}
