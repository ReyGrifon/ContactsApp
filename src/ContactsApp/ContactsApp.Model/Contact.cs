using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp.Model
{
    internal class Contact : ICloneable
    {
        private string _fullName;

        private DateTime _dateOfBirth;

        private string _phoneNumber;

        private string _vkId;

        private string _email;

        private string _phoneNumberRegex = @"(^[+]?[0-9]{1}\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2})";

        public string FullName
        { 
            get 
            { 
                return _fullName; 
            } 
            set 
            { 
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Name can't be less 0 symbols");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Name can't be longer to 100 symbols");
                }
                _fullName = value;
            } 
        }

        public DateTime DateOfBirth
        {
            get 
            {
                return _dateOfBirth; 
            }
            set 
            {
                if (value.Year < 1900 || value.Year == DateTime.Today.Year)
                {
                    throw new ArgumentException("Year of birth can't be curent year and before 1900");
                }
                _dateOfBirth = value;
            }
        }

        public string PhoneNumber
        {
            get 
            {
                return _phoneNumber;
            }
            set 
            {
                if (!Regex.IsMatch(value,_phoneNumberRegex)!)
                {
                    throw new ArgumentException("Number does not fit the pattern 8(123)000-45-67 or +7(123)000-45-67");
                }
                _phoneNumber = value; 
            }
        }

        public string VkId
        {
            get 
            { 
            return _vkId;
            }
            set 
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("VK ID can't be less 0 symbols");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("VK ID can't be longer to 50 symbols");
                }
                _vkId = value; 
            }
        }

        public string Email
        {
            get 
            {
                return _email;
            }
            set 
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Email can't be less 0 symbols");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Email can't be longer to 100 symbols");
                }
                _email = value; 
            }
        }

        public Contact(string fullName,DateTime dateOfBirth, string phonenumber, string vkId, string email)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = PhoneNumber;
            VkId = VkId;
            Email = email;
        }

        public object Clone() => new Contact(FullName, DateOfBirth, PhoneNumber, VkId, Email);
    }
}
