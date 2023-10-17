using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o raio");
            float raio = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura");
            float altura = int.Parse(Console.ReadLine());
            float volume = 3.14159f * raio * raio * altura;
            Console.WriteLine(volume);
            Console.ReadLine();
        }
    }
}
