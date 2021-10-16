using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CConsoleFinalProject.Classes
{
    class Student
    {
        public int temp;
        public int count = 1;
        public string Fullname { get; set; } //eyni full name ola biler,amma yene de bosluga   Bunu massiv kimi varsayib Grupunu ctor una gonderme
                                             //gore yeni ad kimi goturmek pr olarmi oyren.
        public string GroupNo { get; set; }
        public EduType Type { get; set; }
        public Student(string fullname,string grno,EduType eduType)
        {
            temp = count;     
            Fullname = fullname;
            GroupNo = grno;
            Type = eduType;
            switch (eduType)
            {
                case EduType.Guaranteed:
                    break;
                case EduType.Unguaranteed:
                    break;
                default:
                    break;
            }
            count++;
        }
        public override string ToString()
        {
            return $"{Fullname}\n{GroupNo}\n{Type}";
        }
    }
}
