using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CConsoleFinalProject.Classes
{
    class Group
    {
        public static int count = 1;
        public string No { get; set; } 
        public EduCategory Category { get; set; }
        public IsOnline IsOnline { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; }


        public Group(IsOnline isOnline,EduCategory category)
        {
            Students = new List<Student>();

            Category = category;
            IsOnline = isOnline;

            switch (category)
            {
                case EduCategory.Programming:
                    No = "PR" + count;
                    break;
                case EduCategory.Design:
                    No = "D" + count;
                    break;
                case EduCategory.System_Administration:
                    No = "SA" + count;
                    break;
                default:
                    break;
            }
            count++;
        }
        public override string ToString()
        {
            return $"No: {No}\nIsonline: {IsOnline}\nCategory: {Category}";
        }
    }
}
