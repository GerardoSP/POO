using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoDeAreas;
using Personas;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Ponce = new Persona();

            Ponce.Nombre = "Cristian Antonio";
            Ponce.Edad = 28;
            Ponce.Altura = 1.84m;

            Persona Marcos = new Persona();

            Marcos.Nombre = "Marcos";
            Marcos.Edad = 27;
            Marcos.Altura = 1.60m;

            Persona Gerardo = new Persona();

            Console.WriteLine($"Accion--> {Ponce.Correr()}");

            Ponce.Correr();
            AreaTriangulo(10.5m, 10.00m);

            Console.ReadKey();
        }

        
        
        static decimal AreaTriangulo(decimal bases , decimal altura)
        {
            return (bases*altura)/2;
        }


    }
}
