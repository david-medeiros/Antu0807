using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anto0807
{
    class Program
    {
        static int p;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para achar sua raiz quadrada");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sqrt(p));
            Console.ReadKey();
        }
        static int sqrt(int n)
        {
            int i = 1;
            int c = 1;
            int dif = n - i;
            while (dif != 0)
            {
                n -= i;
                i += 2;
                dif = n - i;
                c++;
            }
            return c;
        }
    }
}
