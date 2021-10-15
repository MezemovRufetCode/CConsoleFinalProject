using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CConsoleFinalProject.Classes
{
    class Student
    {
        public string Fullname { get; set; } //eyni full name ola biler,amma yene de bosluga
                                             //gore yeni ad kimi goturmek pr olarmi oyren.
        public string GroupNo { get; set; }
        public EduType Type { get; set; }
        public Student()
        {

        }
    }
}
