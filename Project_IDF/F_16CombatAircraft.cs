using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal class F_16CombatAircraft : Weapon
    {
        public override string Name { get; set; }
        public override int AmmoInventory { get; set; }
        public override string AttackToolEffectiveness { get; set; }
        public override string FuelLevel { get; set; }
        public static int InstanceCount { get; private set; }


        public F_16CombatAircraft(string name , int ammoInventory = 8, string attackToolEffectiveness = "buildings")
        {

            Name = name;
            AmmoInventory = ammoInventory;
            AttackToolEffectiveness = attackToolEffectiveness;
            InstanceCount++;
            
        }
        public void AddToInvetory(Weapon weap,int amount)
        {
            weap.AmmoInventory += amount;
            Console.WriteLine($" the amount of bobs is: {weap.AmmoInventory}");

        }

        // מונה גלובלי לכל מופעי המטוסים מסוג זה









    }
}
