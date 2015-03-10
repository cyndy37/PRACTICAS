using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int seg1 = 0, seg2 = 0;
            int min1 = 0, min2 = 0;
            int hrs1 = 0, hrs2 = 0;
            

            for (int c = 0; c <= 86400; c++)
            {
                Console.WriteLine("\n     ******** CRONOMETRO ********");
                Console.WriteLine("\n     ******** INICIALIZANDO********");
                Console.WriteLine("\n   " + hrs2 + hrs1 +" : " + min2 + min1 + " : " + seg2 + seg1);
                seg1++;
                Thread.Sleep(100);
                Console.Clear();

                if(seg1 == 10)
                  {
                      seg2++;
                      seg1 = 0;
                  }
                if (seg2 == 6)
                {
                    min1++;
                    seg1 = 0;
                    seg2 = 0;
                }
                if (min1 == 10)
                {
                    min2++;
                    seg1 = 0;
                    seg2 = 0;
                    min1 = 0;

                }
                if (min2 == 6)
                {
                    hrs1++;
                    seg1 = 0;
                    seg2 = 0;
                    min1 = 0;
                    min2 = 0;
                }
                if (hrs1 == 10)
                {
                    hrs2++;
                    seg1 = 0;
                    seg2 = 0;
                    min1 = 0;
                    min2 = 0;
                    hrs1 = 0;
                }
            }
            Console.ReadKey();
         }
    }           
}
