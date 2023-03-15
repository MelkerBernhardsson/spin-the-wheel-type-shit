using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            Console.WriteLine("Välkommen till lyckohjulet! Välj ett tal mellan 1 och 10 och se om du vinner!!");
            int choice = int.Parse(Console.ReadLine());
            int hjultal = slump.Next(1,11);
            Console.WriteLine("hjulet stannade på talet: "+ hjultal);
            if (choice == hjultal)
            {
                Console.WriteLine("du gissade rätt! Grattis!!");
            }
            else
            {
                Console.WriteLine("du gissade tyvärr inte rätt :(");
            }
        }
    }
}
