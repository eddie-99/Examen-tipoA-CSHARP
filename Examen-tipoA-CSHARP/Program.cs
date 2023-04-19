using System;
using Examen_tipoA_CSHARP.Models;

namespace Examen_tipoA_CSHARP 
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Variables
            int opc;
            int j;

            Console.Write("Alumnos a registrar: ");
            Alumno.n = int.Parse(Console.ReadLine());
            Alumno[] alumnos = new Alumno[Alumno.n];

            for (j = 0; j == 0;)
            {
                opc = menu();

                switch (opc)
                {
                    case 1:
                        for (Alumno.i = 0; Alumno.i < Alumno.n; Alumno.i++)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tALTA DE ALUMNO: " + Alumno.i + "\n");
                            Alumno nuevoAlumno = new Alumno();
                            nuevoAlumno.alta();
                            alumnos[Alumno.i] = nuevoAlumno;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escriba el id del alumno a eliminar: ");
                        Alumno.i = int.Parse(Console.ReadLine());
                        alumnos[Alumno.i].baja();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Escriba el id del alumno que desea cambiar los datos: ");
                        Alumno.i = int.Parse(Console.ReadLine());
                        alumnos[Alumno.i].cambio();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Escriba el id del alumno a consultar: ");
                        Alumno.i = int.Parse(Console.ReadLine());
                        alumnos[Alumno.i].consulta();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\t\tREPORTE");
                        Console.WriteLine("id" + "\t" + "Grupo" + "\t" + "Boleta" + "\t" + "\t" + "Nombre" + "\t" + "Periodo" + "\t" + "Cal.Final");
                        for (Alumno.i = 0; Alumno.i < Alumno.n; Alumno.i++)
                        {
                            alumnos[Alumno.i].reporte();
                        }
                        break;

                    case 6:
                        Console.WriteLine("Gracias por usar el sistema, vuelva pronto.\n");
                        j = 1;
                        break;

                    default:
                        Console.WriteLine("\nOpcion no valida, intenta nuevamente\n");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("\tMenu principal\n");
            Console.WriteLine("1.- Alta de alumnos");
            Console.WriteLine("2.- Baja de alumnos");
            Console.WriteLine("3.- Cambio de datos de alumnos");
            Console.WriteLine("4.- Consulta de alumnos");
            Console.WriteLine("5.- Reporte de alumnos");
            Console.WriteLine("6.- Salir\n");

            Console.Write("Teclee opcion: ");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }
}
