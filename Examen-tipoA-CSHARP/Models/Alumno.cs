using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_tipoA_CSHARP.Models
{
    class Alumno
    {
        //Variables globales
        public static int i = 0;
        public static int n = 0;

        //Atributos
            private int numAlumno;
            private string grupo;
            private string boleta;
            private string nombre;
            private int calif1;
            private int calif2;
            private int calif3;
            private string periodo;
            private float promedio;
            private float califExtra;
            private float califFinal;
        
        // Constructores de la clase Alumno
        public Alumno(int numAlumno, string grupo, string boleta, string nombre, int calif1, int calif2, int calif3, string periodo)
            {
                this.numAlumno = i;
                this.grupo = grupo;
                this.boleta = boleta;
                this.nombre = nombre;
                this.calif1 = calif1;
                this.calif2 = calif2;
                this.calif3 = calif3;
                this.periodo = periodo;
                this.promedio = (calif1 + calif2 + calif3) / 3;
                this.califExtra = 0;
                this.califFinal = 0;
            }

        public Alumno()
        {
        }

        //Destructor de la clase Alumno
        ~Alumno() { }

        //Declaración de los métodos de la clase Alumno
        public int alta()
        {
            numAlumno = i;

            Console.Write("Escribe el grupo del alumno: ");
            grupo = Console.ReadLine();
            Console.Write("Escribe la boleta del alumno: ");
            boleta = Console.ReadLine();
            Console.Write("Escribe el nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.Write("Escribe la calificación del 1er parcial: ");
            calif1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe la calificación del 2do parcial: ");
            calif2 = int.Parse(Console.ReadLine());
            Console.Write("Escribe la calificación del 3er parcial: ");
            calif3 = int.Parse(Console.ReadLine());
            Console.Write("Escribe el periodo escolar: ");
            periodo = Console.ReadLine();

            promedio = (calif1 + calif2 + calif3) / 3;

            Console.Write("Escribe la calificación del extraordinario: ");
            califExtra = float.Parse(Console.ReadLine());

            if (califExtra > promedio)
            {
                califFinal = califExtra;
            }
            else
            {
                califFinal = promedio;
            }

            return 0;
        }

        public int baja()
        {
            numAlumno = 0;
            grupo = " ";
            boleta = " ";
            nombre = " ";
            calif1 = 0;
            calif2 = 0;
            calif3 = 0;
            periodo = " ";
            promedio = 0.0f;
            califExtra = 0.0f;
            califFinal = 0.0f;

            return 0;
        }

        public int cambio()
        {
            //Variables
            int opc;
            int j;

            //for infinito
            for (j = 0; j == 0;)
            {
                opc = menuCambio();

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Escriba el grupo del alumno: ");
                        grupo = Console.ReadLine();
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escriba la boleta del alumno: ");
                        boleta = Console.ReadLine();
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Escriba el nombre del alumno: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Escriba la calificación del 1er parcial: ");
                        calif1 = int.Parse(Console.ReadLine());
                        promedio = (calif1 + calif2 + calif3) / 3;
                        if (califExtra > promedio)
                        {
                            califFinal = califExtra;
                        }
                        else
                        {
                            califFinal = promedio;
                        }
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Escriba la calificación del 2do parcial: ");
                        calif2 = int.Parse(Console.ReadLine());
                        promedio = (calif1 + calif2 + calif3) / 3;
                        if (califExtra > promedio)
                        {
                            califFinal = califExtra;
                        }
                        else
                        {
                            califFinal = promedio;
                        }
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Escriba la calificación del 3er parcial: ");
                        calif3 = int.Parse(Console.ReadLine());
                        promedio = (calif1 + calif2 + calif3) / 3;
                        if (califExtra > promedio)
                        {
                            califFinal = califExtra;
                        }
                        else
                        {
                            califFinal = promedio;
                        }
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Escriba el periodo escolar: ");
                        periodo = Console.ReadLine();
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("Escriba la calificación del extra: ");
                        califExtra = float.Parse(Console.ReadLine());
                        if (califExtra > promedio)
                        {
                            califFinal = califExtra;
                        }
                        else
                        {
                            califFinal = promedio;
                        }
                        Console.WriteLine("Se cambio correctamente.");
                        break;

                    case 9:
                        Console.WriteLine("Saliendo del menu de cambio...\n");
                        j = 1;
                        break;

                    default:
                        Console.WriteLine("\nOpcion no valida, intenta nuevamente\n");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            }
            return 0;
        }

        public int consulta()
        {
            Console.WriteLine("Alumno: " + numAlumno);
            Console.WriteLine("Grupo: " + grupo);
            Console.WriteLine("Boleta: " + boleta);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Calificación 1er parcial: " + calif1);
            Console.WriteLine("Calificación 2do parcial: " + calif2);
            Console.WriteLine("Calificación 3er parcial: " + calif3);
            Console.WriteLine("Periodo escolar: " + periodo);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Extra: " + califExtra);
            Console.WriteLine("Calificación final: " + califFinal);

            return 0;
        }

        public int reporte()
        {
            Console.WriteLine(i + "\t" + grupo + "\t" + boleta + "\t" + nombre + "\t" + periodo + "\t" + califFinal);
            return 0;
        }

        // Métodos para obtener y establecer los valores de los atributos privados
        public int GetNumAlumno()
            {
                return numAlumno;
            }

        public void SetNumAlumno(int numAlumno)
            {
                this.numAlumno = numAlumno;
            }

        public string GetGrupo()
            {
                return grupo;
            }

        public void SetGrupo(string grupo)
            {
                this.grupo = grupo;
            }

        public string GetBoleta()
            {
                return boleta;
            }

        public void SetBoleta(string boleta)
            {
                this.boleta = boleta;
            }

        public string GetNombre()
            {
                return nombre;
            }

        public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

        public float GetCalif1()
            {
                return calif1;
            }

        public void SetCalif1(int calif1)
            {
                this.calif1 = calif1;
            }

        public float GetCalif2()
            {
                return calif2;
            }

        public void SetCalif2(int calif2)
            {
                this.calif2 = calif2;
            }

        public float GetCalif3()
            {
                return calif3;
            }

        public void SetCalif3(int calif3)
            {
                this.calif3 = calif3;
            }

        public string GetPeriodo()
            {
                return periodo;
            }

        public void SetPeriodo(string periodo)
            {
                this.periodo = periodo;
            }

        public float GetPromedio()
            {
                return promedio;
            }

        public void SetPromedio(float promedio)
            {
                this.promedio = promedio;
            }

        public float GetCalifExtra()
            {
                return califExtra;
            }

        public void SetCalifExtra(float califExtra)
            {
                this.califExtra = califExtra;
            }

        public float GetCalifFinal()
            {
                return califFinal;
            }

        public void SetCalifFinal(float califFinal)
            {
                this.califFinal = califFinal;
            }

        static int menuCambio()
        {
            Console.Clear();
            Console.WriteLine("\tMenu cambio\n");
            Console.WriteLine("1.- Grupo alumno");
            Console.WriteLine("2.- Boleta alumno");
            Console.WriteLine("3.- Nombre alumno");
            Console.WriteLine("4.- Calificación 1er parcial");
            Console.WriteLine("5.- Calificación 2do parcial");
            Console.WriteLine("6.- Calificación 3er parcial");
            Console.WriteLine("7.- Periodo escolar");
            Console.WriteLine("8.- Calificación extra");
            Console.WriteLine("9.- Salir\n");

            Console.Write("Teclee opcion: ");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }

}

