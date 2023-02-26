using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3Students
{
    public class Student
    {

        #region Properties-Fields
        private List<string> _history;

        public readonly int _id;
        public int ID
        {
            get
            {
                return _id;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AddHistory("Name", _name, value);
                _name = value;
            }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                string pattern = @"^\d+@\d+.\d+$";
                if (Regex.IsMatch(value, pattern))
                {
                    _email = value;
                }
            }
        }

        private string _major;
        public string Major
        {
            get
            {
                if(_isPrivate == false)
                {
                    return _major;
                }
                return "Access Denied";
            }
            set
            {
                AddHistory("Major", _name, value);
                _major = value;
            }
        }

        private string _startDate;
        public string StartDate 
        {
            get
            {
                if (_isPrivate == false)
                {
                    return _major;
                }
                return "Access Denied";
            }

            set
            {
                AddHistory("StartDate", _startDate, value);
                _startDate = value;
            }
        }
        private string _anticipatedGraduationDate;
        public string AnticipatedGraduationDate 
        {
            get
            {
                if(_isPrivate == false) 
                {
                    return _anticipatedGraduationDate;
                }
                return null;
            }

            set
            {
                AddHistory("AnticipatedGraduationDate",_anticipatedGraduationDate,value);
                _anticipatedGraduationDate = value;
            }
        }
        private string _stateProvinceTerritory;
        public string StateProvinceTerritory 
        {
            get 
            {
                if(_isPrivate == false)
                {
                    return _stateProvinceTerritory;
                }
                return null;
            }

            set
            {
                AddHistory("StateProvinceTerritory",_stateProvinceTerritory, value);
                _stateProvinceTerritory = value;
            }
        }
        private string _country;
        public string Country 
        {
            get 
            {
                if(_isPrivate == false)
                {
                    return _country;
                }
                return null;
            }
            set
            {
                AddHistory("Country", _country, value);
            }
        }

        private int _phoneNumber;
        public int PhoneNumber
        {
            get
            {
                if (_isPrivate == false)
                {
                    return _phoneNumber;
                }
                return 0;
            }
            set
            {
                AddHistory("PhoneNumber",_phoneNumber.ToString(), value.ToString());
            }
        }
        private string _mailingAddress;
        public string MailingAddress
        {
            get
            {
                if (_isPrivate == false)
                {
                    return _mailingAddress;
                }
                return null;
            }
            set
            {
                AddHistory("MailingAddress",_mailingAddress, value);
            }
        }
        private bool _isPrivate = false;


        #endregion







        #region Methods


        private void AddHistory(string property, string from, string to)
        {
            _history.Add(property + ": " + from + "=> " + to);
        }

        void PrintStudentInfo()
        {
            Console.Write(_name + ": ");
            Console.Write(", ID: " + _id);
            Console.Write(", Email: " + _email);
            if (_isPrivate == false)
            {
                Console.Write(", Major: " + _major);
                Console.Write(", StartDate: " + _startDate);
                Console.Write(", GradDate: " + _anticipatedGraduationDate);
                Console.Write(", Area: " + _stateProvinceTerritory);
                Console.Write(", Country: " + _country);
                Console.Write(", PhoneNumber: " + _phoneNumber);
                Console.Write(", MailingAddress: " + _mailingAddress);
            }
            
        }


        #endregion

        #region Constructors
        public Student(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public Student(int id,string name,string major,string country,string email, int phoneNumber, string mailingAddress)
        {
            _id = id;
            _name= name;
            _major = major;
            _country = country;
            _email = email;
            _phoneNumber = phoneNumber;
            _mailingAddress = mailingAddress;
        }
        #endregion

    }
}
