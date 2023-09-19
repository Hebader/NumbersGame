namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random randomerare = new Random(); // skapar en varibel för att slunmpa tal.
            int slump_tal = randomerare.Next(1, 21); //Slumpar ett tal mellan 1-20.
            int AnändareTal = int.Parse(Console.ReadLine());


            for (int i = 1; i < 5; i++)
            {
               

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


                AnändareTal = int.Parse(Console.ReadLine());

            }
            if (AnändareTal != slump_tal) 
            {
                Console.WriteLine( "Tyvärr, du lyckades inte gissa talet på fem försök.");
            }
                  
                    
               
                        
                
            
        }
        static CheckGuess();
    }
}