using System;

namespace Tarea04_21
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Escribe un día de la semana (en minúscula)");
                string dia = Console.ReadLine();

                switch (dia)
                {
                    case "lunes":
                    case "martes":
                    case "miércoles":
                    case "jueves":
                    case "viernes":
                        Console.WriteLine("Día Laboral ...Toca trabajar.");
                        break;
                    case "sábado":
                    case "domingo":
                        Console.WriteLine("Día no laboral ... Relájate... es FIN DE SEMANA.");
                        break;
                    default:
                        Console.WriteLine("ERROR ese día no existe...");
                        break;
                }



                Console.ReadKey();
            }
    }
}
