using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Doctor : Person
    {
        string doctorID;
        int yearsOfPractice;
        double shiftHours;

        public Doctor(string doctorID, int yearsOfPractice, double shiftHours, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.doctorID = doctorID;
            this.yearsOfPractice = yearsOfPractice;
            this.shiftHours = shiftHours;
        }

        public string DoctorID
        {
            get { return this.doctorID; }
            set
            {
                if (doctorID.Length != 10)
                {
                    Console.WriteLine("Doctor ID must have exactly 10 character!");
                }
                this.doctorID = value;
            }
        }

        public int YearsOfPractice
        {
            get { return this.yearsOfPractice;}
            set { this.yearsOfPractice = value;}
        }

        public double ShiftHours
        {
            get { return this.shiftHours;}
            set { this.shiftHours = value;}
        }

        public string getID()
        {
            return DoctorID;
        }

        public int getYearsOfPractice()
        {
            return YearsOfPractice;
        }

        public double getShiftHours()
        {
            return ShiftHours;
        }

        public string toString()
        {
            return DoctorID + " " + YearsOfPractice + " " + ShiftHours + " " + base.toString();
        }
    }
}
