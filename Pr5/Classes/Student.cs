using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Scholarship = false;
        public int Course = 4;
        public string ImagePath { get; set; } = "/Images/incognito.jpg";

        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }

        public Student(string Firstname, string Lastname, string Surname, bool Scholarship) : this(Firstname, Lastname, Surname)
        {
            this.Scholarship = Scholarship;
        }

        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course) : this(Firstname, Lastname, Surname, Scholarship)
        {
            this.Course = Course;
        }

        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course, string ImagePath)
            : this(Firstname, Lastname, Surname, Scholarship, Course)
        {
            this.ImagePath = ImagePath;
        }

        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}
