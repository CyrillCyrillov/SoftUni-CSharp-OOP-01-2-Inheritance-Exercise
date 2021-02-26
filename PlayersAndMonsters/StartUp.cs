using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster test = new SoulMaster("John", 15);
            Knight boom = new Knight("Phill", 10);

            Console.WriteLine(test);
            Console.WriteLine(boom);
        }
    }
}