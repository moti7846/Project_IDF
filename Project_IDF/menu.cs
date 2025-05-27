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

        public void start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the IDF system");
            PrintMenu();
            menu();
        }

        public void menu()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט
                    Console.Clear();
                    PrintMenu_1();
                    menu_1();
                    break;
                case 2:
                    // אמן - מעבר לתפריט ל1_2
                    Console.Clear();
                    PrintMenu_2();
                    menu_2();
                    break;
                case 0:
                    //יציאה מהתוכנית
                    Console.WriteLine("good day !");
                    return;
                default:
                    Console.WriteLine("choice: 1 or 2 or 0.");
                    menu();
                    break;
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||  1. Attack                      ||");
            Console.WriteLine("||  2. Artist                      ||");
            Console.WriteLine("||  0. Exit                        ||");
            Console.WriteLine("=====================================");

        }
        public void menu_1()
        {
            int choice = ChoiceMenu();
                switch (choice)
                {
                    case 1:
                    //תקיפה - מעבר לתפריט
                    Console.Clear();
                    PrintMenu_1_1();
                        menu_1_1();
                        break;
                    case 2:
                        // אמן - מעבר לתפריט ל1_2
                        Console.Clear();
                        PrintMenu_1_2();
                        menu_1_2();
                        break;
                    case 9:
                        // חזרה תפריט אחד קודם
                        Console.Clear();
                        PrintMenu();
                        menu();
                        break;
                    case 0:
                        //יציאה מהתוכנית
                        Console.WriteLine("good day !");
                        return;
                    default:
                        Console.WriteLine("choice: 1 or 2 or 3 or 9 or 0.");
                        menu_1();
                        break;
                }
            start();
        }
        public void PrintMenu_1()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||   1. Inventory                   ||");
            Console.WriteLine("||   2. Attack                      ||");
            Console.WriteLine("||   3. History Attack              ||");
            Console.WriteLine("||   9. Back                        ||");
            Console.WriteLine("||   0. Exit                        ||");
            Console.WriteLine("=====================================");
        }
        public void menu_1_1()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט

                    break;
                case 2:
                    // אמן - מעבר לתפריט ל1_2

                    break;
                case 9:
                    // חזרה תפריט אחד קודם
                    Console.Clear();
                    PrintMenu_1();
                    menu_1();
                    break;
                case 0:
                    //יציאה מהתוכנית
                    Console.WriteLine("good day !");
                    return;
                default:
                    Console.WriteLine("choice: 1 or 2 or 9 or 0.");
                    menu_1_1();
                    break;
            }
            start();
        }
        public void PrintMenu_1_1()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||   1. View Inventory             ||");
            Console.WriteLine("||   2. Update Inventory           ||");
            Console.WriteLine("||   9. Back                       ||");
            Console.WriteLine("||   0. Exit                       ||");
            Console.WriteLine("=====================================");

        }
        public void menu_1_2()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט

                    break;
                case 2:
                    // אמן - מעבר לתפריט ל1_2

                    break;
                case 9:
                    // חזרה תפריט אחד קודם
                    Console.Clear();
                    PrintMenu_1();
                    menu_1();
                    break;
                case 0:
                    //יציאה מהתוכנית
                    Console.WriteLine("good day !");
                    return;
                default:
                    Console.WriteLine("choice: 1 or 2 or 9 or 0.");
                    menu_1_2();
                    break;
            }
            start();
        }
        public void PrintMenu_1_2()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||   1. Automatic attack           ||");
            Console.WriteLine("||   2. Manual attack              ||");
            Console.WriteLine("||   9. Back                       ||");
            Console.WriteLine("||   0. Exit                       ||");
            Console.WriteLine("=====================================");

        }
        public void menu_1_3()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט

                    break;
                case 2:
                    // אמן - מעבר לתפריט ל1_2

                    break;
                case 9:
                    // חזרה תפריט אחד קודם
                    Console.Clear();
                    PrintMenu_1();
                    menu_1();
                    break;
                case 0:
                    //יציאה מהתוכנית
                    Console.WriteLine("good day !");
                    return;
                default:
                    Console.WriteLine("choice:9 or 0.");
                    menu_1_3();
                    break;
            }
            start();
        }
        public void PrintMenu_1_3()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||   1. null                       ||");
            Console.WriteLine("||   2. null                       ||");
            Console.WriteLine("||   9. Back                       ||");
            Console.WriteLine("||   0. Exit                       ||");
            Console.WriteLine("=====================================");

        }
        ///
        public void menu_2()
        {
            int choice = ChoiceMenu();
            switch (choice)
            {
                case 1:
                    //תקיפה - מעבר לתפריט
                    Console.WriteLine("null");
                    break;
                case 2:
                    // אמן - מעבר לתפריט ל1_2
                    Console.WriteLine("null");
                    break;
                case 3:
                    //תקיפה - מעבר לתפריט
                    Console.WriteLine("null");
                    break;
                case 4:
                    // אמן - מעבר לתפריט ל1_2
                    Console.WriteLine("null");
                    break;
                case 9:
                    // חזרה תפריט אחד קודם
                    Console.Clear();
                    PrintMenu();
                    menu();
                    break;
                case 0:
                    //יציאה מהתוכנית
                    Console.WriteLine("good day !");
                    return;
                default:
                    Console.WriteLine("choice: 1 or 2 or 3 or 4 or 9 or 0.");
                    menu_2();
                    break;
            }
            start();
        }
        public void PrintMenu_2()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("||   1. Add a terrorist            ||");
            Console.WriteLine("||   2. Update a terrorist         ||");
            Console.WriteLine("||   3. Show a terrorist           ||");
            Console.WriteLine("||   4. Show terrorists            ||");
            Console.WriteLine("||   9. Back                       ||");
            Console.WriteLine("||   0. Exit                       ||");
            Console.WriteLine("=====================================");
        }
    }
}
