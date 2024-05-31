using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetVet
{
    public class Log
    {
        public int IdClient {  get; set; }
        public int IdAnimal { get; set; }
        public int IdWorker { get; set; }
        public DateTime Date {  get; set; }
        public TimeSpan Time { get; set; }
        public string Symptoms { get; set; }
        public Log(int idClient, int idAnimal, int idWorker, DateTime date, TimeSpan time, string symptoms)
        {
            IdClient = idClient;
            IdAnimal = idAnimal;
            IdWorker = idWorker;
            Date = date;
            Time = time;
            Symptoms = symptoms;
        }
    }
}
