using System;
using System.Collections.Generic;

namespace LabNet2023.Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> omnibusList = new List<TransportePublico>();
            List<TransportePublico> taxiList = new List<TransportePublico>();
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Cargar Pasajeros en los ómnibus");
                Console.WriteLine("2. Cargar Pasajeros en los taxis");
                Console.WriteLine("3. Listado de pasajeros en cada transporte publico");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        int i;
                        for (i = 0; i < 5; i++)
                        {
                            Console.Write($"Ingrese la cantidad de pasajeros hay en el ómnibus: ");
                            int Pasajeros = Convert.ToInt32(Console.ReadLine());
                            omnibusList.Add(new Omnibus(Pasajeros));
                        }
                        break;
                    case 2:
                        Console.Clear();
                        for (i = 0; i < 5; i++)
                        {
                            Console.Write($"Ingrese la cantidad de pasajeros que hay en el taxi: ");
                            int Pasajeros = Convert.ToInt32(Console.ReadLine());
                            taxiList.Add(new Taxi(Pasajeros));
                        }
                        break;
                    case 3:
                        Console.Clear();
                        i = 0;
                        foreach (var omnibus in omnibusList)
                        {
                            i++;
                            Console.WriteLine($"Ómnibus {i}: {omnibus.Pasajeros} pasajeros");
                        }
                        i = 0;
                        foreach (var taxi in taxiList)
                        {
                            i++;
                            Console.WriteLine($"Taxi {i}: {taxi.Pasajeros} pasajeros");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
