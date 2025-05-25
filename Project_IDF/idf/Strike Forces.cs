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
        List<Weapon> StrikeForceslist;
        public F_16CombatAircraft Aircraft = new F_16CombatAircraft();
        public Hermes_460_Drone Drone = new Hermes_460_Drone();
        public Artillery artillery = new Artillery();

        public  Strike_Forces() { }
        

        public void AddNewAircraftWeapon()
        {
            StrikeForceslist.Add(Aircraft);
        }

        public void AddNewDroneWeapon()
        {
            StrikeForceslist.Add(Drone);
        }

        public void AddNewArtilleryWeapon()
        {
            StrikeForceslist.Add(artillery);
        }

        public int GetNumberOfAttackTools()
        {
            return StrikeForceslist.Count();
        }

        public string Printallstrikes()
        {
            return StrikeForceslist.ToString();
        }
    }
}




        



    

    
