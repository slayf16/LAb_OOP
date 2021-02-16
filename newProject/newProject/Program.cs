using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Как вас зовут?");
            a = Console.ReadLine();

            Console.WriteLine($"привет {a}, хорошего тебе дня!!!");

            Console.ReadKey();
        }
    }
}
