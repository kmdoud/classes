using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    class Student
    {
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _phone;
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length < 7 || value.Length > 12)
                    Console.WriteLine("ERROR");
                else
                {
                    _phone = value;
                }
            }
        }
        public string Email;
        private double _GPA;
        public double GPA
        { get
            {
                return _GPA;
            }
            set
            {
                if (value < 0.0 || value > 5.0)
                {
                    Console.WriteLine("GPA Must be between 0 and 5");

                }
                else
                {
                    _GPA = value;
                }
            }
        }
        public int SAT { get; set; }
        


        public Student(string fname, string lname, string email, string phone, double gpa, int sat)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Phone = phone;
            GPA = gpa;
            SAT = sat;

        }
        public Student()
        {
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";

        }
        public string Print()
        {
            return $"{FirstName} {LastName} | {Phone}| {Email}| {GPA}| {SAT}|";
        }

        public string Print(string message)
        {
            return $"{message} :: " + Print();
        }

    }
}
