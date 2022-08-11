using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_XiaoFengHuang_2195414.BLL
{
    public class Student
    {
        private String? id;
        private string? firstName;
        private string? lastName;
        private string? phoneNumber;

        public Student() { }
        public Student(string id, string? firstName, string? lastName, string? phoneNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public string? Id { get => id; set => id = value; }
        public string? FirstName { get => firstName; set => firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
