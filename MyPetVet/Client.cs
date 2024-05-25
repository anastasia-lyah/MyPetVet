using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetVet
{
    class Client
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Client(string fullName, string address, string phone)
        {
            FullName = fullName;
            Address = address;
            Phone = phone;
        }
    }
}
