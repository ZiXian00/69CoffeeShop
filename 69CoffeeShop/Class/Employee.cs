using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69CoffeeShop.Class
{
    public class Employee
    {
        public string employeeID { get; set; }
        public string employeeName { get; set; } 
        public string dateOfBirth { get; set; }
        public string position { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string employmentStatus { get; set; }
        public string bankName { get; set; }
        public string bankAccountNo { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string emergencyContact { get; set; }
        public string identityNo { get; set; }
        public string gender { get; set; }
        public string dateHired { get; set; }
        public string lastCheckedIn { get; set; }
        public string lastCheckedOut { get; set; }

        public Employee()
        {

        }

        public Employee(string employeeID, string employeeName, string dateOfBirth, string position, string contactNo, string email, string employmentStatus, string bankName, string bankAccountNo, string address, int age, string emergencyContact, string identityNo, string gender, string dateHired, List<Employee> onDutyList)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.position = position;
            this.contactNo = contactNo;
            this.email = email;
            this.employmentStatus = employmentStatus;
            this.bankName = bankName;
            this.bankAccountNo = bankAccountNo;
            this.address = address;
            this.age = age;
            this.emergencyContact = emergencyContact;
            this.identityNo = identityNo;
            this.gender = gender;
            this.dateHired = dateHired;
        }
    }
}
