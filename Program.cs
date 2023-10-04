using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utskrift till användaren
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
           
            CheckGuess(); // lägger in metoden "CheckGuess()" i Main metoden.
        }

        static void CheckGuess()  //Skapar en metod
        { 
            Random randomerare = new Random(); // skapar en varibel för att slunmpa tal.
            int slump_tal = randomerare.Next(1, 21); //Slumpar ett tal mellan 1-20.

            for (int i = 1; i <= 5; i++) // En for loop som kör från 1-5, dvs 5 gånger.
            {
                int AnändareTal;
                string input = Console.ReadLine();  //Användaren skriver in en siffra
                bool isString = int.TryParse(input, out AnändareTal);
       

                if (slump_tal < AnändareTal) // Villkor

                {
                    Console.WriteLine("Tyvärr, du gissade för Högt!"); //Utskrift om villkoret stämmer

                }
                else if (slump_tal > AnändareTal) // Om första villkoret inte stämmer 

                {
                    Console.WriteLine("Tyvärr, du gissade för Lågt!");
                }


                else if (slump_tal == AnändareTal) // Om varken första eller andra villkoret stämmer
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break; // Om användaren gissar rätt avbryts loopen
                }

                if (i == 5) // När användaren gissat 5 gånger kommer detta skrivas ut

                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök.");

                }
            }








        } 

    }
}