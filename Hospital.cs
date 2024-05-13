using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Hospital
    {
        Patients myPatients = new Patients();
        Doctors myDoctors = new Doctors();
        Nurses myNurses = new Nurses();

        public string addPatient(string patientID, string sectionNumber, double balance, string dischargeStatus, string firstname, string lastname, int departmentCode)
        {
            string message = "";
            if (patientID.Length != 10)
            {
                message = "Error! Patient ID should be 10 characters";
            }
            else
            {
                if (patientVerifier(patientID) == true)
                {
                    message = "Error! This ID already exists!";
                }
                else
                {
                    if (firstname.Length > 50 || lastname.Length > 50)
                    {
                        message = "Error! Names should be below 50 characters each";
                    }
                    else
                    {
                        Patient patient = new Patient(patientID, sectionNumber, 0.0, dischargeStatus, firstname, lastname, departmentCode);
                        myPatients.add(patient);
                        message = "Success! Item has been added to the list";
                    }
                }
            }
            return message;
        }

        public bool patientVerifier(string patientID)
        {
            bool flag = false;
            foreach (Patient patient in myPatients)
            {
                if (patient.getID() == patientID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public string addDoctor(string doctorID, int yearsOfPractice, double shiftHours, string firstname, string lastname, int departmentCode)
        {
            string message = "";
            if (doctorID.Length != 10)
            {
                message = "Error! Doctor ID should be 10 characters";
            }
            else
            {
                if (doctorVerifier(doctorID) == true)
                {
                    message = "Error! This ID already exists!";
                }
                else
                {
                    if (firstname.Length > 50 || lastname.Length > 50)
                    {
                        message = "Error! Names should be below 50 characters each";
                    }
                    else
                    {
                        Doctor doctor = new Doctor(doctorID, yearsOfPractice, 0.0, firstname, lastname, departmentCode);
                        myDoctors.add(doctor);
                        message = "Success! Item has been added to the list";
                    }
                }
            }
            return message;
        }

        public bool doctorVerifier(string doctorID)
        {
            bool flag = false;
            foreach (Doctor doctor in myDoctors)
            {
                if (doctor.getID() == doctorID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public string addNurse(string nurseID, int yearsOfPractice, double shiftHours, int numberOfPatients, string firstname, string lastname, int departmentCode)
        {
            string message = "";
            if (nurseID.Length != 10)
            {
                message = "Error! Nurse ID should be 10 characters";
            }
            else
            {
                if (nurseVerifier(nurseID) == true)
                {
                    message = "Error! This ID already exists!";
                }
                else
                {
                    if (firstname.Length > 50 || lastname.Length > 50)
                    {
                        message = "Error! Names should be below 50 characters each";
                    }
                    else
                    {
                        Nurse nurse = new Nurse(nurseID, yearsOfPractice, 0.0, numberOfPatients, firstname, lastname, departmentCode);
                        myNurses.add(nurse);
                        message = "Success! Item has been added to the list";
                    }
                }
            }
            return message;
        }

        public bool nurseVerifier(string nurseID)
        {
            bool flag = false;
            foreach (Nurse nurse in myNurses)
            {
                if (nurse.getID() == nurseID)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
