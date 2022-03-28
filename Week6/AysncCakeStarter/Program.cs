using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            await HaveAPartyAsync();
            Console.WriteLine("Thanks for a lovely party");

            CleanUp();
            Console.ReadLine();            
        }

        private static async Task HaveAPartyAsync()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            var cake = await cakeTask;
            SingHappyBdayAsync();                          
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        private static async Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }

        private static async Task SingHappyBdayAsync()
        {
            Console.WriteLine("Everyone gather around. Let's sing together");
            await Task.Delay(TimeSpan.FromSeconds(2));            
        }

        private static async Task CleanUp()
        {
            Console.WriteLine("Now it's time to clean!");
            Console.WriteLine("What a mess");
            await Task.Delay(TimeSpan.FromMinutes(45));
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }
}
