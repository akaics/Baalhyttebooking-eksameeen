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
            Reservationer reservation1 = new Reservationer();
            Reservationer reservation2 = new Reservationer();
            Reservationer reservation3 = new Reservationer();

            //Tester klassen Reservationer ved at udskrive instanser af unikke ID:

            Console.WriteLine("-------Reservationer--------");
            Console.WriteLine(reservation1);
            Console.WriteLine(reservation2);
            Console.WriteLine(reservation3);
            Console.WriteLine("-------------**-------------");
        }
    }
}