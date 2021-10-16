using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CConsoleFinalProject.Services
{
     static class MenuService
    {
        public static CourseServices courseServices = new CourseServices();
        #region Groupun yaradilmasi
        public static void CreateGroupMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Choose the category ***");
            Console.WriteLine("--------------------------------");
            foreach (var cat in Enum.GetValues(typeof(EduCategory)))
            {
                Console.WriteLine($"{(int)cat}.{cat}");
            }
            Console.WriteLine("--------------------------------");
            int category;
            string categoryStr = Console.ReadLine();
            bool catresult = int.TryParse(categoryStr, out category);
            if (catresult)
            {
                switch (category)
                {
                    case 1:
                        string No = courseServices.CreateGroup(EduCategory.Programming);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($" *** {No} Group succesfully created. ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    case 2:
                        No = courseServices.CreateGroup(EduCategory.Design);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($" *** {No} Group succesfully created. ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    case 3:
                        No = courseServices.CreateGroup(EduCategory.System_Administration);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($" *** {No} Group succesfully created. ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Groupun edit olunmasi
        public static void EditGroupMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Please enter group no ***");
            Console.WriteLine("--------------------------------");
            string groupNo = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Please enter new group no ***");
            Console.WriteLine("--------------------------------");
            string newgroupNo = Console.ReadLine();
            courseServices.EditGroup(groupNo, newgroupNo);
        }
        #endregion

        #region Butun grouplarin gosterilmesi
        public static void ShowAllGroupMenu()
        {
            courseServices.GetAllGroups();          
        }
        #endregion

        #region Studentin yaradilmasi
        public static void CreateStudentMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Please enter student fullname ***");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Example:Rufet Mezemov name and surname with 1 space and first letters capitalized.");
            string fname = Console.ReadLine();
            //int fn;
            //bool fnameres = int.TryParse(fname, out fn);
            //if (fnameres)
            //{
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine($"{fname} is not a name! Pls enter name");
            //    Console.WriteLine("--------------------------------");
            //    return;
            //}
            Regex regex = new Regex(@"[A-Z][a-z]* [A-Z][a-z]*");
            if (!regex.IsMatch(fname)) {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Pls enter valid name");
                Console.WriteLine("--------------------------------");
                return;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Please enter gruop no ***");
            Console.WriteLine("--------------------------------");

            string grno = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Choose education type ***");
            Console.WriteLine("--------------------------------");
            foreach (var cat in Enum.GetValues(typeof(EduType)))
            {
                Console.WriteLine($"{(int)cat}.{cat}");
            }
            Console.WriteLine("--------------------------------");
            int category;
            string categoryStr = Console.ReadLine();
            bool categoryStrresult = int.TryParse(categoryStr, out category);
            if (categoryStrresult)
            {
                switch (category)
                {
                    case 1:
                        CourseServices courseServices = new CourseServices();
                        string No = courseServices.CreateStudent(fname, grno, EduType.Guaranteed);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"Fullname - {fname}\nGroup No - {grno.ToUpper()}\nEdu Type - {EduType.Guaranteed}");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" *** Student succesfully created ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    case 2:
                         courseServices = new CourseServices();
                         No = courseServices.CreateStudent(fname, grno, EduType.Unguaranteed);
                        Console.WriteLine($"Fullname - {fname}\nGroup No - {grno.ToUpper()}\nEdu Type - {EduType.Unguaranteed}");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" *** Student succesfully created ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Butun qrup telebelerinin gosterilmesi
        public static void ShowAllGroupStudentMenu()
        {
            Console.WriteLine("Please enter group no");
            string grno = Console.ReadLine();
            courseServices.GetGroupStudents(grno);
        }
        #endregion
    }
}
