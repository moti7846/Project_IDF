using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF
{
    internal class Menu
    {

        //קבלת קלט מהמשתמש ובדיקת תקינות הבחירה
        public int ChoiceMenu()
        {
            int choice;
            string temp;

            Console.Write("enter yuor choice: ");
            temp = Console.ReadLine();

            if (int.TryParse(temp, out choice))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The value received is incorrect.");
                ChoiceMenu();
            }
            return choice;
        }

        public static void start()
        {

        }

        public void menu()
        {
            int choice = ChoiceMenu();
            
            switch (choice)
            {
                case 1:
                    //מלאי - מעבר לתפריט  ל1_1

                    break;
                case 2:
                    // תקיפה - מעבר לתפריט ל1_2
                    break;
                case 3:
                    // אמ"ן - מעבר לתפריט ל1_2
                    break;
                case 10:
                    //exit
                    return;
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("1. התקפה)");
            Console.WriteLine("2. אמן");

        }

        public void menu_1()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט  ל1_1

                    break;
                case 2:
                    // אמ"ן - מעבר לתפריט ל1_2

                    break;
                case 10:
                    //exit
                    return;
            }
        }

        public void menu_2()
        {

        }
        public void PrintMenu_2()
        {

            Console.WriteLine("1. Input a Series. (Replace the current series)");
            Console.WriteLine("2. Display the series in the order it was entered.");
        }
        
    }
}
