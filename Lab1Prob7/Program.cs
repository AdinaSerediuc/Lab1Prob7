using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex7
 Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
 impar
  In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
  Google :even and odd number
            */

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine( x + " este numar par " );
            }
            else
                Console.WriteLine(x + " este numar impar ");
        }
    }
}
