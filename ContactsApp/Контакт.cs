using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Контакт : ICloneable
    {
        private string _lastName;
        private string _firstName;
        private string _email;
        private string _vkId;
        private DateTime _birthDate;
        private string birthDate;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("LastName cannot exceed 50 characters.");
                _lastName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("FirstName cannot exceed 50 characters.");
                _firstName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public Номер_телефона PhoneNumber { get; set; }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value < new DateTime(1900, 1, 1) || value > DateTime.Now)
                    throw new ArgumentException("BirthDate must be between 01/01/1900 and today.");
                _birthDate = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Email cannot exceed 50 characters.");
                _email = value;
            }
        }

        public string VkId
        {
            get => _vkId;
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("VkId cannot exceed 15 characters.");
                _vkId = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Контакт(string lastName, string firstName, Номер_телефона phoneNumber, DateTime birthDate, string email, string vkId)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Email = email;
            VkId = vkId;
        }

        public Контакт(string lastName, string firstName, Номер_телефона phoneNumber, string birthDate, string email, string vkId)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            this.birthDate = birthDate;
            Email = email;
            VkId = vkId;
        }
    }
}
/// 