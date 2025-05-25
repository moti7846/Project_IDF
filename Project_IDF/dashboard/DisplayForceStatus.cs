using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_IDF.IDF;

namespace project_IDF.dashboard
{
    internal class DisplayForceStatus
    {
        public static  void Displayer(Data_Idf data)
        {
            foreach (var item in data.Database.Values)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine( "the weapon is: "+ item1.Name + " the invetory is:  "
                        + item1.AmmoInventory + " "
                        +" its effectiv for: "+ item1.AttackToolEffectiveness + " "
                        + item1.FuelLevel);
                }


            }
        }
    }
}
