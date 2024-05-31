using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetVet
{
    public class MedicalRecord
    {
        public int IdMedrec { get; set; }
        public int IdAnimal { get; set; }
        public int IdWorker { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendations { get; set; }
        public MedicalRecord(int idAnimal, int idWorker, DateTime date, string description, string diagnosis, string recommendations)
        {
            IdAnimal = idAnimal;
            IdWorker = idWorker;
            Date = date;
            Description = description;
            Diagnosis = diagnosis;
            Recommendations = recommendations;
        }
    }
}
