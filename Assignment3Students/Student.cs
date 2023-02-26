using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Students
{
    public class Student
    {



        #region Properties-Fields
        private List<string> _history;

        private void AddHistory(string property, string from, string to)
        {
            _history.Add(property + ": " + from + "=> " + to);
        }

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

        private string _major;
        public string Major
        {
            get
            {
                return _major;
            }
            set
            {
                AddHistory("Major", _name, value);
                _major = value;
            }
        }

        private string _startDate;
        private string _anticipatedGraduationDate;
        private string _stateProvinceTerritory;
        private string _country;
        private string _email;
        private int _phoneNumber;
        private string _mailingAddress;
        private bool _isPrivate = false;

        #endregion







        #region Methods




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
