// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;
namespace Typrwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello there. I'm Raga the golden dragon";

            Typewriter(message, 100);

            Console.WriteLine("\nI'm leader of the raga luara guild.");
            Console.WriteLine("\nhello. how are you");
            Console.WriteLine("Hatsune Miku is Best");
            Console.ReadKey();
    
    
        }
        
        static void Typewriter(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}