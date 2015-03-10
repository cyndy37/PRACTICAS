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
            
            
            while (true)
            {
               
               Console.Clear();
               Console.WriteLine("\n     ********  RELOJ  ********");
               Console.WriteLine("\n******** LA HORA ACTUAL ES:******** \n");


               Console.WriteLine ("\n"+DateTime.Now.ToLongTimeString() );
               Thread.Sleep(1000);
          }
     }
} 



        }
    

