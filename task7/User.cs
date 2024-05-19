using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        public string Pin {  get; set; }

        public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            if(pin.IsTrue()) 
            { 
                Pin = pin;
            }
            else
            {
                Console.WriteLine("Pini duzgun daxil etmemisiniz");
            }

        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname}, {RegistrationMonth}, {Pin}");
        }


    }

   
}

