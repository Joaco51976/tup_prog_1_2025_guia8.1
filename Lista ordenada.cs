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
            string nombre1 = "", nombre2 = "", nombre3 = "";
            int libreta1 = 0, libreta2 = 0, libreta3 = 0;
            double nota1a = 0, nota1b = 0, nota1c = 0;
            double nota2a = 0, nota2b = 0, nota2c = 0;
            double nota3a = 0, nota3b = 0, nota3c = 0;

            bool datosCargados = false;
            int opcion;

            do
            {
                Console.WriteLine("\nElija una opción:");
                Console.WriteLine("1- Registrar las notas de los tres alumnos");
                Console.WriteLine("2- Mostrar lista ordenada por número de libreta");
                Console.WriteLine("3- Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del primer alumno:");
                        nombre1 = Console.ReadLine();

                        Console.WriteLine("Ingrese su número de libreta:");
                        libreta1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese sus 3 notas:");
                        nota1a = Convert.ToDouble(Console.ReadLine());
                        nota1b = Convert.ToDouble(Console.ReadLine());
                        nota1c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del segundo alumno:");
                        nombre2 = Console.ReadLine();

                        Console.WriteLine("Ingrese su número de libreta:");
                        libreta2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese sus 3 notas:");
                        nota2a = Convert.ToDouble(Console.ReadLine());
                        nota2b = Convert.ToDouble(Console.ReadLine());
                        nota2c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del tercer alumno:");
                        nombre3 = Console.ReadLine();

                        Console.WriteLine("Ingrese su número de libreta:");
                        libreta3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese sus 3 notas:");
                        nota3a = Convert.ToDouble(Console.ReadLine());
                        nota3b = Convert.ToDouble(Console.ReadLine());
                        nota3c = Convert.ToDouble(Console.ReadLine());

                        datosCargados = true;
                        break;

                    case 2:
                        if (!datosCargados)
                        {
                            Console.WriteLine("Primero debe registrar los datos de los alumnos.");
                        }
                        else
                        {
                            double promedio1 = (nota1a + nota1b + nota1c) / 3;
                            double promedio2 = (nota2a + nota2b + nota2c) / 3;
                            double promedio3 = (nota3a + nota3b + nota3c) / 3;

                            Console.WriteLine("\nLista ordenada por número de libreta:");

                            if (libreta1 <= libreta2 && libreta1 <= libreta3)
                            {
                                Console.WriteLine($"{nombre1} - Libreta: {libreta1} - Promedio: {promedio1:F2}");
                                if (libreta2 <= libreta3)
                                {
                                    Console.WriteLine($"{nombre2} - Libreta: {libreta2} - Promedio: {promedio2:F2}");
                                    Console.WriteLine($"{nombre3} - Libreta: {libreta3} - Promedio: {promedio3:F2}");
                                }
                                else
                                {
                                    Console.WriteLine($"{nombre3} - Libreta: {libreta3} - Promedio: {promedio3:F2}");
                                    Console.WriteLine($"{nombre2} - Libreta: {libreta2} - Promedio: {promedio2:F2}");
                                }
                            }
                            else if (libreta2 <= libreta1 && libreta2 <= libreta3)
                            {
                                Console.WriteLine($"{nombre2} - Libreta: {libreta2} - Promedio: {promedio2:F2}");
                                if (libreta1 <= libreta3)
                                {
                                    Console.WriteLine($"{nombre1} - Libreta: {libreta1} - Promedio: {promedio1:F2}");
                                    Console.WriteLine($"{nombre3} - Libreta: {libreta3} - Promedio: {promedio3:F2}");
                                }
                                else
                                {
                                    Console.WriteLine($"{nombre3} - Libreta: {libreta3} - Promedio: {promedio3:F2}");
                                    Console.WriteLine($"{nombre1} - Libreta: {libreta1} - Promedio: {promedio1:F2}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{nombre3} - Libreta: {libreta3} - Promedio: {promedio3:F2}");
                                if (libreta1 <= libreta2)
                                {
                                    Console.WriteLine($"{nombre1} - Libreta: {libreta1} - Promedio: {promedio1:F2}");
                                    Console.WriteLine($"{nombre2} - Libreta: {libreta2} - Promedio: {promedio2:F2}");
                                }
                                else
                                {
                                    Console.WriteLine($"{nombre2} - Libreta: {libreta2} - Promedio: {promedio2:F2}");
                                    Console.WriteLine($"{nombre1} - Libreta: {libreta1} - Promedio: {promedio1:F2}");
                                }
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}