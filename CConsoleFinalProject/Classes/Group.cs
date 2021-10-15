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
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public Student[] Students { get; set; }
        public Group(EduCategory category)
        {
            Category = category;
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
        }
        public override string ToString()
        {
            return $"No: {No}, Category: {Category}";
        }
    }
}
