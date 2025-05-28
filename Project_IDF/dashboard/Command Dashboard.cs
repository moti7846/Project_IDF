using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using project_IDF;
using project_IDF.dashboard;
using static project_IDF.dashboard.Command_Dashboard;


namespace project_IDF
{
    internal class Command_Dashboard
    {
        
        Command_Dashboard() { }

        public static void InvetoriMenu()
            
                Strike_Forces data = new Strike_Forces();
                Console.WriteLine("┌─────────────────────────┐");
                Console.WriteLine("│       InvetoriMenu      │");
                Console.WriteLine("└─────────────────────────┘");
                // הצגת כמות תחמושת לפי שם כלי
                DisplayForceStatus.DisplayAmmunitionStatus(data, "f16_2");


                //  הצגת כל הנתונים לפי שם
                DisplayForceStatus.DisplayerByName(data, "Hermes_450_Drone");
                //  הצגת כמות תחמושת לפי סוג כלי
                DisplayForceStatus.DisplayAmmoInventoryByName(data, "Hermes_450_Drone");
                // הצגת כלי תקיפה אפקטיביים לפי מטרה 
                DisplayForceStatus.DisplayStrikeForcesByTarget(data, "buildings");

                DisplayForceStatus.Displayr(data);
                Console.WriteLine("┌─────────────────────────┐");
                Console.WriteLine("│       InvetoriMenu      │");
                Console.WriteLine("└─────────────────────────┘");

           
    
}

