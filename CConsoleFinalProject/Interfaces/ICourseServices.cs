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
        string CreateGroup(IsOnline isOnline,EduCategory category);
        void GetAllGroups(); 
        void EditGroup(string no, string newNo); 
        void GetGroupStudents(string no); 
        void GetAllStudents();
        bool CreateStudent(string fullname, string group, EduType type);
    }
}
