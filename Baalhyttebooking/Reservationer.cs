using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
        //Properties:
        static private int nextId;

        //Get setters:
        public int ID { get; set; }
        
        public Dictionary<int, Reservation> Reservation {get; set;}

        //Constructor:

        public Reservationer()
        {
            ID = Interlocked.Increment(ref nextId);
            Reservation = new Dictionary<int, Reservation>();
        }

        //Implementerer en ToString() metode:
        public override string ToString()
        {
            return $"Reservationernes ID: {ID}";
        }
    }
}
