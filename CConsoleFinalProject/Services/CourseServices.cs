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

        private List<Student> _students => new List<Student>();
        public List<Student> Students => _students;

        #region Groupun yaradilmasi------------Tam deyil.
        public string CreateGroup(EduCategory category)  //not okay
        {
            Group group = new Group(category);
            _groups.Add(group);
            return group.No;
        }
        #endregion

        #region Studentin yaradilmasi
        public string CreateStudent(string fullname, string groupNo, EduType type)  //-------
        {
            Student student = new Student(fullname, groupNo, type);         
            _students.Add(student);
            return $"{student.Fullname} {student.GroupNo} {student.Type}";
        }
        #endregion

        #region  EditGroup ve onun find metodu. -Okay
        public void EditGroup(string no, string newNo)  
        {
            Group Exgroup = FindGroup(no);
            
            if (Exgroup == null)
            {
                Console.WriteLine($" *** {no} group does not exist ***");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim()==newNo.ToLower().Trim())
                {
                    Console.WriteLine($" *** {newNo} has already existed ***");
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

        #region Butun qruplarin gosterilmesi ---------Qrupdaki telebelerin sayinin gosterilmesi qalib
        public void GetAllGroups()    //-----
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no group");
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
        public void GetAllStudents() //------bu metod ucun group yaratmagi tamamlamaliyam
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Butun qrup telebelerinin gosterilmesi
        public void GetGroupStudents()  //------  bu metod ucun group yaratmagi tamamlamaliyam
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("There is no student");
                return;
            }
            foreach (Student std in _students)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(std);
                Console.WriteLine("--------------------------------");
            }
        }
        #endregion
    }
}
