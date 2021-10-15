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
        public Group(string fullname,int limit,EduCategory category)
        {
            Category = category;
            //Students = new Student[fullname];
            //for (int i = 0; i < limit; i++)
            //{
            //    Students[i] = new Student(fullname);
            //}
        }
    }
}
