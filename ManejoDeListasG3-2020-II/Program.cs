using System;
using System.Collections.Generic;

namespace ManejoDeListasG3_2020_II
{
    class Program
    {
        static void Main()
        {
            List<string> nombresProductos = new List<string>();

            nombresProductos.Add("Revolver");
            nombresProductos.Add("Uzi");
            nombresProductos.Add("Shuriken");
            nombresProductos.Add("Kunai");
            nombresProductos.Add("Katana");
            nombresProductos.Add("Sable Lazer");
            
            foreach( string producto in nombresProductos  )
            {
                Console.WriteLine("Producto: " + producto);
            }

            Console.WriteLine("Ingresa el nombre del producto");
            string productoSelect = Console.ReadLine();
            
            for(int i=0; i < nombresProductos.Count; i++)
            {
                if( productoSelect == nombresProductos[i]   )
                {
                    nombresProductos.RemoveAt(i);
                    Console.WriteLine("Producto comprado");
                }
            }
            Console.WriteLine("Productos");

            foreach (string producto in nombresProductos)
            {
                Console.WriteLine("Producto: " + producto);
            }

            Console.WriteLine("Agrga un producto");
            string prductInsert = Console.ReadLine();
            Console.WriteLine("Es arma blanca o arma de fuego, 1 para arma blanca 2 para arma de fuego");
            byte op = byte.Parse(Console.ReadLine());
            if (op==1)
            {
                nombresProductos.Insert(4, prductInsert);

            }
            else
            {
                nombresProductos.Insert(1, prductInsert);
            }

            foreach (string producto in nombresProductos)
            {
                Console.WriteLine("Producto: " + producto);
            }

        }
    }
}
