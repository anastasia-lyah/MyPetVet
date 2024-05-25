using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetVet
{
    public class Animal
    {
        public int IdClient { get; set; }
        public int IdSpecies { get; set; }
        public int IdBreed { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        public Animal(int idClient, int idSpecies, int idBreed, string name, DateTime dateBirth)
        {
            IdClient = idClient;
            IdSpecies = idSpecies;
            IdBreed = idBreed;
            Name = name;
            DateBirth = dateBirth;
        }
    }
}
