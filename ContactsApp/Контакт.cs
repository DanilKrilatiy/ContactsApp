using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Контакт : ICloneable
    {
        private string lastName;
        private string firstName;
        private long phoneNumber;
        private DateTime birthDate;
        private string email;
        private string vkId;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value.Substring(0, Math.Min(value.Length, 50)).ToUpper(); }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.Substring(0, Math.Min(value.Length, 50)).ToUpper(); }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value.Year >= 1900 && value <= DateTime.Now)
                {
                    birthDate = value;
                }
                else
                {
                    Console.WriteLine("Invalid birth date.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value.Substring(0, Math.Min(value.Length, 50)); }
        }

        public string VkId
        {
            get { return vkId; }
            set { vkId = value.Substring(0, Math.Min(value.Length, 15)); }
        }

        public string Name { get; set; }
        public Номер_телефона Phone { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Last Name: {LastName}");
            sb.AppendLine($"First Name: {FirstName}");
            sb.AppendLine($"Phone Number: {PhoneNumber}");
            sb.AppendLine($"Birth Date: {BirthDate.ToShortDateString()}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"VK ID: {VkId}");
            return sb.ToString();
        }
    }
}
/// 