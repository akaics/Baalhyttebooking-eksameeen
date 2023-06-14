using System.Security.Cryptography.X509Certificates;

namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Laver instanser af BoerneGruppe:

           
            BoerneGruppe boerneGruppe1 = new BoerneGruppe("Gruppe 01", "Den yngste gruppe", "Pusling", 3);
            BoerneGruppe boerneGruppe2 = new BoerneGruppe("Gruppe 02", "Den midterste gruppe", "Tumling", 5);
            BoerneGruppe boerneGruppe3 = new BoerneGruppe("Gruppe 03", "Yndlingerne", "Ældste", 7);

            //Tester klassen BoerneGruppe ved at udskrive instanser:

            Console.WriteLine("-------BørneGrupper--------");
            Console.WriteLine(boerneGruppe1);
            Console.WriteLine(boerneGruppe2);
            Console.WriteLine(boerneGruppe3);
            Console.WriteLine("-------------**-------------");

            //Laver instanser af reservation klassen:
            Reservation reservation1 = new Reservation(DateTime.Now, boerneGruppe1);
            Reservation reservation2 = new Reservation(DateTime.Now, boerneGruppe2);
            Reservation reservation3 = new Reservation(DateTime.Now, boerneGruppe3);
        
            

            //Tester klassen Reservation ved at udskrive instanser af unikke ID:

            Console.WriteLine("-------Reservationer--------");
            Console.WriteLine(reservation1);
            Console.WriteLine(reservation2);
            Console.WriteLine(reservation3);
            Console.WriteLine("-------------**-------------");
        }
    }
}