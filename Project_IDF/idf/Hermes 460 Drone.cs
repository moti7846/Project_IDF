using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal class Hermes_460_Drone:Weapon
           {
            public override string Name { get; set; }
            public override int AmmoInventory { get; set; }
            public override string AttackToolEffectiveness { get; set; }
            public override string FuelLevel { get; set; }

            public Hermes_460_Drone(string name = "zik", int ammoInventory = 3, string attackToolEffectiveness = "People" +"Vehicles")
            {
                Name = name;
                AmmoInventory = ammoInventory;
                AttackToolEffectiveness = attackToolEffectiveness;
            }
            public override void RemoveWeapon()
            {
                AmmoInventory -= 1;

            }
        }
}
