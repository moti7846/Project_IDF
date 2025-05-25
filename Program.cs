using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_IDF.dashboard;
using project_IDF.IDF;


namespace project_IDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F_16CombatAircraft f1 = new F_16CombatAircraft();
            Hermes_460_Drone h1 = new Hermes_460_Drone();
            Artillery ar1 = new Artillery();
            Data_Idf data = new Data_Idf();
            data.AddNewWeapon(f1);
            data.AddNewWeapon(h1);
            data.AddNewWeapon(ar1);
            DisplayForceStatus.Displayer(data);

            

     

        }
    }
}
