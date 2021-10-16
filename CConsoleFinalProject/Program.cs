using CConsoleFinalProject.Enums;
using CConsoleFinalProject.Services;
using System;

namespace CConsoleFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("  **** Welcome to Course **** ");
            Console.WriteLine();
            int selection;
            do
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Create a group");
                Console.WriteLine("2. Show all groups");
                Console.WriteLine("3. Edit group");
                Console.WriteLine("4. Show students of group");
                Console.WriteLine("5. Show all students");
                Console.WriteLine("6. Create a student");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------");

                
                string selectStr = Console.ReadLine();
                bool result = int.TryParse(selectStr, out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.CreateGroupMenu();
                            break;
                        case 2:
                            MenuService.ShowAllGroupMenu();
                            break;
                        case 3:
                            MenuService.EditGroupMenu();
                            break;
                        case 4:
                            MenuService.ShowAllGroupStudentMenu();
                            break;
                        case 6:
                            MenuService.CreateStudentMenu();
                            break;
                        
                        default:
                            break;
                    }
                }
            } while (selection!=0);
        }
    }
}
