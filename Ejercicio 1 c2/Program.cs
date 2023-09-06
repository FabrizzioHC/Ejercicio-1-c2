using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola esta usted en la agencia turística");
            Console.WriteLine("por favor, ingrese la cantidad de días de estadía:");
            int diasdeestadia = int.Parse(Console.ReadLine());
            Console.WriteLine("elije la categoría del hotel solo ponga 3 o 5 no hay necesidad de poner (estrellas) (3 estrellas, 5 sstrellas):");
            int categoriaHotel = int.Parse(Console.ReadLine());
            double costopordia = 0;

            if (categoriaHotel == 3)
            {
                if (diasdeestadia >= 1 && diasdeestadia <= 5)
                {
                    costopordia = 100.00;
                }
                else if (diasdeestadia >= 6 && diasdeestadia <= 10)
                {
                    costopordia = 85.00;
                }
                else if (diasdeestadia >= 11)
                {
                    costopordia = 70.00;
                }
            }
            else if (categoriaHotel == 5)
            {
                if (diasdeestadia >= 1 && diasdeestadia <= 5)
                {
                    costopordia = 300.00;
                }
                else if (diasdeestadia >= 6 && diasdeestadia <= 10)
                {
                    costopordia = 270.00;
                }
                else if (diasdeestadia >= 11)
                {
                    costopordia = 250.00;
                }
            }
            else
            {
                Console.WriteLine("intenta denuevo pero esta vez solo pon 3 o 5");
                return;
            }

            double costoTotal = costopordia * diasdeestadia;
            double costoDesayuno = 7.00 * diasdeestadia;
            double costoFinal = costoTotal + costoDesayuno;
            Console.WriteLine("El costo total del hospedaje es: S/." + costoFinal);

        
        }
    }
}
