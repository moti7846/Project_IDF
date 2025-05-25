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

        public F_16CombatAircraft(string name = "f16",int ammoInventory = 8,string attackToolEffectiveness = "buildings")
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
