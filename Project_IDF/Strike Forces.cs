using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal class Strike_Forces
    {


        //!!! THE FIRST INIT FOR THE WEAPONS DATA!!!//
        // now is intilizied a new dict with name "database", that hea is containes the data of all wepons;
        public Dictionary<string, List<Weapon>> Database = new Dictionary<string, List<Weapon>>();

        public Strike_Forces()
        {
            // setting the new lists of weapons:
            // a list of aircraft f16;
            Database["F16CombatAircraft"] = new List<Weapon>();
            // a list of artillery m109;
            Database["Artillery"] = new List<Weapon>();
            // a list of hermes = zik drones;
            Database["Hermes_450_Drone"] = new List<Weapon>();

            // the defolt is 4 objects from each type of weapon, i add to the dictionary 3 keys and 3 values-the 3 lists of weapons;
            for (int i = 1; i < 5; i++)
            {

                Database["F16CombatAircraft"].Add(new F_16CombatAircraft($"f16_{i.ToString()}"));
                Database["Artillery"].Add(new Artillery($"Artillery_{i.ToString()}"));
                Database["Hermes_450_Drone"].Add(new Hermes_460_Drone($"Zik_{i.ToString()}"));

            }

        }


        // !!! Core Methods for Data Handling!!! //


        // You have the chois to add a new weapon from outside of the class..;
        public void AddNewWeapon(Weapon newWeap)
        {
            if (!Database.ContainsKey(newWeap.Name))
            {
                Database[newWeap.Name] = new List<Weapon>();
            }

            Database[newWeap.Name].Add(newWeap);
        }

        // remove from the immontory when you attack!
        public void RemoveWeaponUnits(string name)
        {
            string Name = name;
            foreach (var item in Database.Values)
            {
                foreach (var item1 in item)
                {
                    if (item1.Name == name)
                    {
                        item1.AmmoInventory -= 1;
                    }
                }

            }
        }
        public void AppendWeaponUnits(string name)
        {
            string Name = name;
            foreach (var item in Database.Values)
            {
                foreach (var item1 in item)
                {
                    if (item1.Name == name)
                    {
                        item1.AmmoInventory += 1;
                        Console.WriteLine($"the {item1.Name} is fool with: {item1.AmmoInventory} bombes!");

                    }
                }

            }
        }

    }
}













