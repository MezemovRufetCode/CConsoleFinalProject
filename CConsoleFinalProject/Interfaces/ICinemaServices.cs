using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CConsoleFinalProject.Interfaces
{
    interface ICinemaServices
    {
        public List <Group> Groups { get;}

        string CreateGroup();
        void GetAllGroups();
        void EditGroup();
        void GetGroupStudents(); //GetAllSeats ile benzerdir bu. 
        void GetAllStudents();
        string CreateStudent();
        

    }
}
