using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF
{
    internal abstract  class Weapon
    {
        public  abstract  string Name { get; set; }

        public abstract int AmmoInventory { get; set; }
        public abstract  string AttackToolEffectiveness { get; set; }
        public abstract  string FuelLevel { get; set; }

        public  abstract void RemoveWeapon();
        


    }
}