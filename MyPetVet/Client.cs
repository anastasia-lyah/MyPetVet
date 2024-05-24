using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetVet
{
    class Client
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Client(string lastName, string firstName, string address, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            Phone = phone;
        }
    }
}
