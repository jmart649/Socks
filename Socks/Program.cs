using System;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            Socks jm = new Socks();
            jm.numberofsocks(9);

            Console.WriteLine("\nI have {0} pairs of socks.", jm.pairs);
            Console.WriteLine("I have {0} leftover individual socks.", jm.remainder);
        }
    }
}
