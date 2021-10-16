using CConsoleFinalProject.Classes;
using CConsoleFinalProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CConsoleFinalProject.Interfaces
{
    interface ICourseServices
    {
        public List<Group> Groups { get; }
        public List<Student> Students { get; }
        string CreateGroup(EduCategory category);//+
        void GetAllGroups(); //++
        void EditGroup(string no, string newNo); //+++
        void GetGroupStudents(string no); //---
        void GetAllStudents(); //---
        string CreateStudent(string fullname, string group, EduType type); //+
    }
}
