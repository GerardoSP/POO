using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasePersonas;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Program calculo = new Program();
            Personas Daniel = new Personas();
            Daniel.Nombre = "Jose";
            Daniel.Edad = 27;
            Daniel.Estatura = 1.80;

            Personas Gerardo = new Personas();
            Gerardo.Nombre = "Gerardo";
            Gerardo.Edad = 26;
            Gerardo.Estatura = 1.84;

            Console.WriteLine($"Mi nombre es {Daniel.Nombre}");
            Console.WriteLine($"Mi edad es {Daniel.Edad}");
            Console.WriteLine(Daniel.Correr());
            Console.WriteLine(calculo.Area(1, 2));
            Console.ReadKey();

        }
        public int Area(int a, int b)
        {
            return a * b;
        }
    }
 
}
