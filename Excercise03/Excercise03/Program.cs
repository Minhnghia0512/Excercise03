using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chao the gioi");
            Hline(10);
        }
        static void Hline(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write("*");
        }
    }
}
