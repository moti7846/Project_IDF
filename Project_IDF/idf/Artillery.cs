using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal class Artillery:Weapon
    {
        public override string Name { get; set; }
        public override int AmmoInventory { get; set; }
        public override string AttackToolEffectiveness { get; set; }
        public override string FuelLevel { get; set; }

        public Artillery(string name = "m109", int ammoInventory = 40, string attackToolEffectiveness = "Open Areas")
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
