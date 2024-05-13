using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Patient : Person
    {
        string patientID;
        string sectionNumber;
        double balance;
        string dischargeStatus;

        public Patient(string patientID, string sectionNumber, double balance, string dischargeStatus, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.patientID = patientID;
            this.sectionNumber = sectionNumber;
            this.balance = balance; 
            this.dischargeStatus = dischargeStatus;
        }

        public string PatientID
        {
            get { return this.patientID; }
            set
            {
                if (patientID.Length != 10)
                {
                    Console.WriteLine("Patient ID must have exactly 10 character!");
                }
                this.patientID = value;
            }
        }

        public string SectionNumber
        {
            get { return this.sectionNumber; }
            set { this.sectionNumber = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public string DischargeStatus
        {
            get { return this.dischargeStatus; }
            set { this.dischargeStatus = value; }
        }

        public string getID()
        {
            return PatientID;
        }

        public string getSectionNumber()
        {
            return sectionNumber;
        }

        public double getBalance()
        {
            return balance;
        }

        public string toString()
        {
            return PatientID + " " + SectionNumber + " " + Balance + " " + DischargeStatus + " " + base.toString();
        }
    }
}
