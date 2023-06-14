using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        //properties:
        static private int nextId;
        public DateTime tidspunkt;
        public BoerneGruppe boerneGruppe;


        //getters og setters:
        public int ID { get; set; }
        public DateTime Tidspunkt { get; set; }
        public BoerneGruppe BoerneGruppe { get; set; }

        //Konstruktør:
        public Reservation(DateTime tidspunkt, BoerneGruppe boerneGruppe) 
        {
            ID = Interlocked.Increment(ref nextId);
            Tidspunkt = tidspunkt;
            BoerneGruppe = boerneGruppe;
        }

        //ToString() metode:

        public override string ToString()
        {
            return $"Reservations information: {ID}, {Tidspunkt}, {BoerneGruppe}";
        }
    }
}
