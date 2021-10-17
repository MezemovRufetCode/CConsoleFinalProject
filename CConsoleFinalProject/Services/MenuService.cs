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

            Console.WriteLine("--------------------------------");
            Console.WriteLine(" *** Choose online or traditional ***");
            Console.WriteLine("--------------------------------");
            foreach (var cat in Enum.GetValues(typeof(IsOnline)))
            {
                Console.WriteLine($"{(int)cat}.{cat}");
            }
            Console.WriteLine("--------------------------------");
            int onln;
            string onlnstr = Console.ReadLine();
            bool onlnstrres = int.TryParse(onlnstr, out onln);

            if (onlnstrres)
            {
                switch (onln)
                {
                    case 1:
                        if (catresult)
                        {
                            switch (category)
                            {
                                case 1:
                                    string No = courseServices.CreateGroup(IsOnline.Online, EduCategory.Programming);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                case 2:
                                    No = courseServices.CreateGroup(IsOnline.Online, EduCategory.Design);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                case 3:
                                    No = courseServices.CreateGroup(IsOnline.Online, EduCategory.System_Administration);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        if (catresult)
                        {
                            switch (category)
                            {
                                case 1:
                                    string No = courseServices.CreateGroup(IsOnline.Traditional, EduCategory.Programming);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                case 2:
                                    No = courseServices.CreateGroup(IsOnline.Traditional, EduCategory.Design);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                case 3:
                                    No = courseServices.CreateGroup(IsOnline.Traditional, EduCategory.System_Administration);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine($" *** {No} Group succesfully created. ***");
                                    Console.WriteLine("--------------------------------");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }         
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
            Regex regex = new Regex(@"[A-Z][a-z]* [A-Z][a-z]*");
            if (!regex.IsMatch(fname))
            {
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
                        courseServices.CreateStudent(fname, grno, EduType.Guaranteed);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"Fullname - {fname}\nGroup No - {grno.ToUpper()}\nEdu Type - {EduType.Guaranteed}");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" *** Student succesfully created ***");
                        Console.WriteLine("--------------------------------");
                        break;
                    case 2:
                        courseServices.CreateStudent(fname, grno, EduType.Unguaranteed);
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
