using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Nurse : Person
    {
        string nurseID;
        int yearsOfPractice;
        double shiftHours;
        int numberOfPatients;

        public Nurse(string nurseID, int yearsOfPractice, double shiftHours, int numberOfPatients, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.nurseID = nurseID;
            this.yearsOfPractice = yearsOfPractice;
            this.shiftHours = shiftHours;
            this.numberOfPatients = numberOfPatients;
        }

        public string NurseID
        {
            get { return this.nurseID; }
            set
            {
                if (nurseID.Length != 10)
                {
                    Console.WriteLine("Nurse ID must have exactly 10 character!");
                }
                this.nurseID = value;
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

        public int NumberOfPatients
        {
            get { return this.numberOfPatients;}
            set { this.numberOfPatients = value;}
        }

        public string getID()
        {
            return NurseID;
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
            return NurseID + " " + YearsOfPractice + " " + ShiftHours + " " + NumberOfPatients + " " + base.toString();
        }
    }
}
