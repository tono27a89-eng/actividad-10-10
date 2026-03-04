using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario de inventario. Permita al usuario eliminar un producto ingresando su código.");


            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine($"Ingrese  ID NO.{i + 1} de 3 productos");
                int.TryParse(Console.ReadLine(), out Id);
                if (estudiante.ContainsKey(Id))
                {
                    Console.WriteLine("ID ya ingresado");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    estudiante.Add(Id, nombre);

                }

            }
            bool validar = false;
            while (validar != true)
            {


                Console.WriteLine("ingrese ID de estudiante que desea elimar");
                int.TryParse(Console.ReadLine(), out Id);
                if (estudiante.ContainsKey(Id))
                {
                    estudiante.Remove(Id);
                    validar = true;
                }
                else
                {
                    Console.WriteLine("ID invalido");
                }
            }
            foreach (var item in estudiante)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
