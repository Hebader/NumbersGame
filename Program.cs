namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random randomerare = new Random(); // skapar en varibel för att slunmpa tal.
            int slump_tal = randomerare.Next(1, 21); //Slumpar ett tal mellan 1-20.
          

            // En for loop som låter användaren gissa 5 gånger.
            for (int i = 0; i < 5; i++) // Börjar loopen från 1 för att användaren redan gissat en gång
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
                    break;
                }



            }

           









        }

    }
}