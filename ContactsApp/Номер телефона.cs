using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Номер_телефона
    {
        private long number;

        public long Number
        {
            get { return number; }
            set
            {
                if (IsRussianPhoneNumber(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number. Please enter a Russian phone number starting with '7'.");
                }
            }
        }

        private bool IsRussianPhoneNumber(long num)
        {
            string numStr = num.ToString();

            return numStr.Length == 11 && numStr[0] == '7';
        }
    }
}