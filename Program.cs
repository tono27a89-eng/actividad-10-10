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
            Dictionary<int, String> producto = new Dictionary<int, String>();
            int ID;
            string nombre;
            Console.WriteLine("ingrese numero de productos");
            int.TryParse(Console.ReadLine(), out int lim);
            for (int i = 0; i < lim; i++)
            {
                Console.WriteLine($"Ingrese  ID NO.{i + 1} de {lim} productos");
                int.TryParse(Console.ReadLine(), out ID);
                if (producto.ContainsKey(ID))
                {
                    Console.WriteLine("ID ya ingresado");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    producto.Add(ID, nombre);

                }

            }
            bool validar = false;
            while (validar != true)
            {
                    Console.WriteLine("ingrese ID de producto que desea elimar");
                int.TryParse(Console.ReadLine(), out ID);
                if (producto.ContainsKey(ID))
                {
                    producto.Remove(ID);
                    validar = true;
                }
                else
                {
                    Console.WriteLine("ID invalido");
                }
            }
            foreach (var item in producto)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
