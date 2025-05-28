using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using project_IDF;
namespace project_IDF
{
    internal class DisplayForceStatus
    {
        // Displays the full list of attack units
        //  מציג את הכלל הכלים לפי שם , מלאי, אפקטיביות 
        public static void Displayer(Strike_Forces data)
        {
            foreach (var item in data.Database.Values)
            {
                foreach (var item1 in item)
                {
                    if (item1.Equals(item1))
                        Console.WriteLine("the weapon is: " + item1.Name + " the invetory is:  "
                        + item1.AmmoInventory + " "
                        + " its effectiv for: " + item1.AttackToolEffectiveness + " "
                        + item1.FuelLevel);
                    
                    
                    

                }


            Console.WriteLine( "     \n");
            }
        }
        // The ammunition status is displayed for the given strike force name
        // מציג מלאי לפי שם פרטי של הכלי
        public static void DisplayAmmunitionStatus(Strike_Forces data, string name)
        {
            foreach (var item in data.Database.Values)
            {
                foreach (var item1 in item)
                {
                    if (item1.Name == name)
                    {
                        Console.WriteLine(item1.AmmoInventory);

                    }
                }


            }
        }
        // מציג את הכמות של הכלים לפי סוג
        public static void DispleyamountOfForcesByName(Strike_Forces data)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("you have in AmmoInventory of strike forces:");
            Console.ResetColor();
            foreach (var item in data.Database)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.ResetColor();

            }


        }

        // הצגת מצב המלאי לפי סוג הכלי
        public static void DisplayerByName(Strike_Forces data, string name)
        {
            foreach (var item in data.Database[name])
            {

                Console.WriteLine("the weapon is: " + item.Name + " the invetory is:  "
          + item.AmmoInventory + " "
          + " its effectiv for: " + item.AttackToolEffectiveness + " "
          + item.FuelLevel);
            }
        }


        // מציג את כמות הנשק לכלל הכלים מאותו סוג

        public static void DisplayAmmoInventoryByName(Strike_Forces data, string name)
        {
            foreach (var item in data.Database[name])
            {
                Console.WriteLine($"the invetory off: {item.Name}  is:{item.AmmoInventory}");
            }
        }


        // מציג איזה כלים מתאימים כולל מלאי נשק לפי מטרה
        public static void DisplayStrikeForcesByTarget(Strike_Forces data ,string target)
        {

            Console.WriteLine("the tools thet is good for this target is:");
            foreach (var item in data.Database)
            {
                foreach (var item1 in item.Value)
                {
                    if (item1.AttackToolEffectiveness.Equals(target))
                    {
                        Console.WriteLine($"{item1.Name}, {item1.AmmoInventory} Bombs is redy for attack");
                       
                      
                    }
                    

                }
            }
            {
            }

            //Console.WriteLine("┌─────────────────────────┐");
            //Console.WriteLine("│     Main Menu           │");
            //Console.WriteLine("└─────────────────────────┘");



        }

    }
}


