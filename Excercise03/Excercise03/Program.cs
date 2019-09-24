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
            Hline(10, '*'); Console.WriteLine();
            Vline(10, 'a'); Console.WriteLine();
            Hline(10, 'b'); Console.WriteLine();
        }
        static void Hline(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }
        static void Vline(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }
        static void DLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Hline(i, ' ');
                Console.WriteLine(" " + c);
            }
        }

        static void DrawTriagle(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {

                }
            }
        }
    }
}
