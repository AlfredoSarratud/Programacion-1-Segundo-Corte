using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int edad = 0;
            double altura = 0.0;

            Console.WriteLine("Hola, esta es la segunda actividad de programacion, la cual segun tu edad y altura, te permite ingresar a algunas atracciones u otras en un parque");
            Console.WriteLine();

            Console.WriteLine("Hola, este es el sistema del parque de diversiones, por favor ingresa tu edad");
            Console.WriteLine();

            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);

            if (edad >= 18)
            {
                Console.WriteLine("Disculpe, usted excede el limite de edad para acceder al parque");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Usted esta dentro de la edad permitida para acceder, ¡bienvenido!");
                Console.WriteLine();

                Console.WriteLine("Porfavor ingresa tu altura en metros");
                Console.WriteLine();

                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);

                if (altura < 1.6)
                {
                    Console.WriteLine("Usted puede acceder a los carritos chocones y al carrusel");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("¡Usted puede acceder a todas las atracciones del parque!");
                }
            }

                Console.ReadLine();
        }
    }
}
