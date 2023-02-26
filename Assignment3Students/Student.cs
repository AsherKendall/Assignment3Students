using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Students
{
    public class Student
    {
        private readonly int _id;
        private string _name;
        private string _major;
        private string _startDate;
        private string _anticipatedGraduationDate;
        private string _stateProvinceTerritory;
        private string _country;
        private string _email;
        private int _phoneNumber;
        private string _mailingAddress;

        public int PhoneNumber { get; set; }


        #region Constructors
        public Student(int id)
        {
            this._id = id;
        }
        public Student(int id,string name,string major,string country,string email, int phoneNumber, string mailingAddress)
        {
            this._id= id;
            this._name= name;
            this._major= major;
            this._country= country;
            this._email= email;
            this._phoneNumber = phoneNumber;
            this._mailingAddress= mailingAddress;
        }
        #endregion

    }
}
