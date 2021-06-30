using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
    class Socks
    {
        List<int> socks = new List<int>();
        private int NumSocks = 0;
        public delegate void MyDelegate();
        private MyDelegate myDelegate;

        public int pairs { get; set; } = 0;
        public int remainder { get; set; } = 0;

        public int numsocks
        {
            get
            {
                return NumSocks;
            }
            set
            {
                NumSocks = value;
            }
        }

        public void numberofsocks(int i)
        {
            numsocks += i;
            Console.WriteLine("There are {0} socks in this pile", NumSocks);

            myDelegate += inputsocks;
            myDelegate += numPairs;
            myDelegate();
        }

        private void inputsocks()
        {
            Console.WriteLine("10 for green, 20 for blue, 30 for red, 40 for pink, 50 for purple");
            for(int i = 0; i < numsocks; i++)
            {
                Console.Write("Enter type of sock: ");
                int type = Convert.ToInt32(Console.ReadLine());

                if(type == 10 || type == 20 || type == 30 || type == 40 || type == 50)
                {
                    socks.Add(type);
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid sock type");
                    break;
                }
            }
        }

        private void numPairs()
        {
            for (int i = 10; i <= 50; i = i + 10)
            {
                var color = (from sock in socks
                              where sock == i
                              select sock)
                              .ToList();
                pairs += color.Count / 2;
                remainder += color.Count % 2;
                color.Clear();
            }
        }
    }
}
