using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    abstract class Person
    {
        string firstname;
        string lastname;
        int departmentCode;

        public Person(string firstname, string lastname, int departmentCode)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.departmentCode = departmentCode;
        }

        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                if (firstname.Length <= 50)
                {
                    Console.WriteLine("Firstname should be lesser than 50 characters!");
                }
                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                if (lastname.Length <= 50)
                {
                    Console.WriteLine("Lastname should be lesser than 50 characters!");
                }
                this.lastname = value;
            }
        }

        public int DepartmentCode
        {
            get { return this.departmentCode; }
            set { this.departmentCode = value; }
        }
        public string toString()
        {
            return Firstname + " " + Lastname + " " + DepartmentCode;
        }
    }
}