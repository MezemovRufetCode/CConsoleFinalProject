 using CConsoleFinalProject.Classes;
using CConsoleFinalProject.Enums;
using CConsoleFinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CConsoleFinalProject.Services
{
    class CourseServices : ICourseServices
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        private List<Student> _students = new List<Student>();
        public List<Student> Students => _students;

        #region Groupun yaradilmasi
        public string CreateGroup(IsOnline ison,EduCategory category)
        {
            Group group = new Group(ison,category);
            _groups.Add(group);
            return group.No;
        }
        #endregion

        #region Studentin yaradilmasi
        public bool CreateStudent(string fullname, string groupNo, EduType type)
        {
            Student student = new Student(fullname, groupNo, type);
            Group group = _groups.Find(c => c.No.ToUpper().Trim() == groupNo.ToUpper().Trim());
            if (group == null)
            {
                Console.WriteLine($" *** {groupNo} group does not exist ***");
                return false;
            }
            else
            {
                
                group.Students.Add(student);
                _students.Add(student);
                return true;
            }           
        }
        #endregion

        #region  EditGroup ve onun find metodu. -Okay
        public void EditGroup(string no, string newNo)  
        {
            Group Exgroup = FindGroup(no);
            
            if (Exgroup == null)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($" *** {no} group does not exist ***");
                Console.WriteLine("--------------------------------");

                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim()==newNo.ToLower().Trim())
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($" *** {newNo.ToUpper()} has already existed ***");
                    Console.WriteLine("--------------------------------");
                    return;
                }
            }
            Exgroup.No = newNo.ToUpper();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($" *** {no.ToUpper()} succesfully updated to {newNo.ToUpper()} ***");
            Console.WriteLine("--------------------------------");
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        #endregion

        #region Butun qruplarin gosterilmesi
        public void GetAllGroups()  
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("There is no group");
                Console.WriteLine("--------------------------------");

                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(group);
                Console.WriteLine("--------------------------------");
            }
        }
        #endregion

        #region Butun telebelerin gosterilmesi
        public void GetAllStudents()
        {

            if (_students.Count == 0)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("There is no student");
                Console.WriteLine("--------------------------------");
                //return;
            }
            else
            {
                foreach (Student student in _students)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(student);
                    Console.WriteLine("--------------------------------");
                }
            }

        }
        #endregion

        #region Butun qrup telebelerinin gosterilmesi
        public void GetGroupStudents(string no) 
        {
            Group group = _groups.Find(g => g.No.ToLower().Trim() == no.ToLower().Trim());
            if (group == null)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"{no} group does not exist");
                Console.WriteLine("--------------------------------");
                return;
            }
            if (group.Students.Count == 0)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("There is no student");
                Console.WriteLine("--------------------------------");
                return;
            }
            foreach (Student std in group.Students)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(std);
                Console.WriteLine("--------------------------------");
            }
        }
        #endregion
    }
}
