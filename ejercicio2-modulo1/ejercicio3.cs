using System;

namespace ejercicio2_modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometrosEntre2Ciudades, velocidadVehiculo, tiempoDeConduccion;


            Console.WriteLine("Ingresar la distancia entre dos ciudades");
            kilometrosEntre2Ciudades = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar velocidad del vehículo");
            velocidadVehiculo = float.Parse(Console.ReadLine());

            tiempoDeConduccion = kilometrosEntre2Ciudades / velocidadVehiculo;

            Console.WriteLine("El tiempo de conducción es de: " + tiempoDeConduccion + " horas");
        }
    }
}
