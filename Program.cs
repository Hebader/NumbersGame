using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
           

            CheckGuess();




        }

           
            static void CheckGuess()
        { 
     

            Random randomerare = new Random(); // skapar en varibel för att slunmpa tal.
            int slump_tal = randomerare.Next(1, 21); //Slumpar ett tal mellan 1-20.

            for (int i = 0; i < 5; i++) // En for loop som kör från 0-4, dvs 5 gånger.
            {
                int AnändareTal = int.Parse(Console.ReadLine()); //Användaren skriver in en siffra

                if (slump_tal < AnändareTal)

                {
                    Console.WriteLine("Tyvärr, du gissade för Högt!");

                }
                else if (slump_tal > AnändareTal)

                {
                    Console.WriteLine("Tyvärr, du gissade för Lågt!");
                }


                else if (slump_tal == AnändareTal)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }

                if (i == 4)

                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök.");

                }
            }








        }

    }
}