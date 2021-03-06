﻿using System;

namespace E1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz1;
            int[,] matriz2;

            int filas;
            int columnas;

            bool sonIguales = true;

            /* ----------- Matriz 1 ----------- */

            Console.WriteLine("Escribe el numero de filas de la Matriz 1");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el numero de columnas de la Matriz 1");
            columnas = int.Parse(Console.ReadLine());

            matriz1 = new int[filas, columnas];

            /* ----------- Matriz 2 ----------- */

            Console.WriteLine("Escribe el numero de filas de la Matriz 2");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el numero de columnas de la Matriz 2");
            columnas = int.Parse(Console.ReadLine());

            matriz2 = new int[filas, columnas];

            /* ----------- Output Matriz 1 ----------- */

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine("Matriz 1: " + matriz1[i, j]);
                }
            }

            /* ----------- Output Matriz 2 ----------- */

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine("Matriz 2: " + matriz2[i, j]);
                }
            }

            /* ----------- Compare Arrays ----------- */

            // Check if they are not same length and exit
            if (matriz1.Length != matriz2.Length)
            {
                Console.WriteLine("Las matrices no pueden ser comparadas");

                return;
            }

            // Continue if they are same length
            Console.WriteLine("Las matrices pueden ser comparadas");

            // Catch exceptions if they arent equal
            try
            {
                // Compare 2D arrays
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (matriz1[i, j] != matriz2[i, j])
                        {
                            sonIguales = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Las matrices no son iguales");
                throw;
            }

            /* - Compare if value has changed after for execution - */
            if (sonIguales)
            {
                Console.WriteLine("Las matrices son iguales");
            }
            else
            {
                Console.WriteLine("Las matrices no son iguales");
            }
        }
    }
}