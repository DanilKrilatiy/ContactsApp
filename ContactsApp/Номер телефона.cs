using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Номер_телефона
    {
        private string _number;

        public string Number
        {
            get => _number;
            set
            {
                if (value.Length != 11 || !long.TryParse(value, out _) || value[0] != '7')
                {
                    throw new ArgumentException("Phone number must be exactly 11 digits long and start with '7'.");
                }
                _number = value;
            }
        }

        public Номер_телефона(string number)
        {
            Number = number;
        }
    }
}