using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class BoerneGruppe
    {
        // properties: 

        string nextId;
        string navn;
        string aldersGruppe;
        int antalDeltagere;
        int id;
        DateTime tidspunkt;
        

        // getters og setters

        public string NextId { get; set; }
        public string Navn { get; set; }
        public string AldersGruppe { get; set; }
        public int AntalDeltagere { get; set; }

        //Konstruktør
        public BoerneGruppe(string nextId, string navn, string aldersGruppe, int antalDeltagere)
        {
            NextId = nextId;
            Navn = navn;
            AldersGruppe = aldersGruppe;
            AntalDeltagere = antalDeltagere;
        }

        //Implementerer en ToString() metode

        public override string ToString()
        {
            return $"BørneGruppernes info: {NextId}, {Navn}, {AldersGruppe}, {AntalDeltagere}";
        }

        ////Metoder der printer børnegruppernes unikke ID: 
        //public void PrintAlleID()
        //{
          
        //    //Bruger en for loop
        //    for (int i = 0; i < ID.Count; i++)
        //    {
        //        Console.WriteLine(ID[i]);
        //    }
        //}

    }
}
