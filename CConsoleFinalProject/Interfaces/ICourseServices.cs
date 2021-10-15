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

        string CreateGroup(EduCategory category);
        void GetAllGroups();
        void EditGroup(string no, string newNo);
        void GetGroupStudents(); //GetAllSeats ile benzerdir bu. bu metod ucun group yaratmaq tamamlanmalidi
        void GetAllStudents();  //Bu metod ucun group yaratmaq tamamlanmalidi
        string CreateStudent(string fullname, string group, EduType type);
    }
}
