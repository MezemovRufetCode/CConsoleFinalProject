using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CConsoleFinalProject.Services
{
     static class MenuService
    {
        public static CourseServices courseServices = new CourseServices();
        public static void CreateGroupMenu()
        {
            Console.WriteLine("Choose the category.");
            foreach (var cat in Enum.GetValues(typeof(EduCategory)))
            {
                Console.WriteLine($"{(int)cat}.{cat}");
            }
            int category;
            string categoryStr = Console.ReadLine();
            bool catresult = int.TryParse(categoryStr, out category);
            if (catresult)
            {
                switch (category)
                {
                    case 1:
                        string No = courseServices.CreateGroup(EduCategory.Programming);
                        Console.WriteLine($"{No} Group succesfully created.");
                        Console.WriteLine();
                        break;
                    case 2:
                        No = courseServices.CreateGroup(EduCategory.Design);
                        Console.WriteLine($"{No} Group succesfully created.");
                        Console.WriteLine();
                        break;
                    case 3:
                        No = courseServices.CreateGroup(EduCategory.System_Administration);
                        Console.WriteLine($"{No} Group succesfully created.");
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Please enter valid group No");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Please enter valid new group No");
            string newgroupNo = Console.ReadLine();
            courseServices.EditGroup(groupNo, newgroupNo);
        }
        public static void ShowAllGroupMenu()
        {
            courseServices.GetAllGroups();          
        }
    }
}
