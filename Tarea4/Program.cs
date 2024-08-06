using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Escribe un programa que imprima en la consola todos los números pares desde 1 hasta 100 utilizando un bucle for.

            // Indicación de lo que va a hacer el programa
            Console.WriteLine("Números pares del 1 al 100");
            // Bucle for para números pares
            for (int i = 2; i  <= 100 ; i += 2) 
            {
                Console.Write(i);
                // Condición para que no imprima la coma y el espacio despues del número 100
                if (i < 100) 
                {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();
            */

            /*
             * 2. Desarrolla un programa que calcule y muestre la suma de todos los números enteros positivos desde 1 hasta un número 
             * ingresado por el usuario utilizando un bucle for.
            
            // Indicación al usuario
            Console.WriteLine("El programa le va dar el resultado de la suma del 1 hasta el número que ingreso");
            // Se solicita que el usuario ingrese un número
            Console.Write("Ingrese un número: ");
            int num2 = int.Parse(Console.ReadLine());
            int suma = 0;
            // Condición que el número ingresado sea mayor a cero
            if (num2 > 0) 
            {
                // Bucle for para realizar la suma hasta el número ingresado
                for (int i = 0; i <= num2; i++)
                {
                    suma += i;
                }
                Console.WriteLine($"La suma desde 1 hasta {num2} es {suma}");
            }
            else
            {
                Console.WriteLine("Número ingresado incorrecto");
            }
            Console.ReadLine();
            */

            /*
             * 3. Crea un programa que imprima en la consola la serie de Fibonacci hasta el décimo término utilizando un bucle for.
             
            // Número de termino
            int n = 10;
            // Variables para almacenar los 2 terminos anteriores
            int a = 0;
            int b = 1;

            Console.WriteLine("Serie Fibnacci hasta el 10mo termino");

            for (int i = 0; i < n; i++) 
            {
                // Imprimir el termino actual
                Console.Write(a + " ");
                // Calcular el siguiente termino 
                int sig = a + b;
                a = b;
                b = sig;
            }
            Console.ReadKey();
            */

            /* 
             * 4. Escribe un programa que genere y muestre en la consola las tablas de multiplicar del 1 al 10 utilizando bucles for anidados.
             
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int num4 = int.Parse(Console.ReadLine());
            // Imprime la tabla de multiplicar para el número ingresado
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num4} * {i} = {num4 * i}");
            }
            Console.ReadKey();
            */

            /* 5. Crea un programa que calcule y muestre el promedio de una serie de números ingresados por el usuario utilizando un bucle for.
            
            // Solicitar al usuario la cantidad de números a ingresar
            Console.WriteLine("Ingresa la cantidad de números para calcular el promedio");
            int cantidad = int.Parse(Console.ReadLine());
            double suma5 = 0;
            // Bucle para ingresar los números y calcular la suma
            for (int i = 1; i <= cantidad; i++) 
            {
                Console.Write($"Ingrese el {i}° número: ");
                double num5 = double.Parse(Console.ReadLine());

                suma5 += num5;
            }
            // Calcular el promedio
            double promedio = suma5 / cantidad;
            Console.WriteLine($"El promdeio de los {cantidad} números ingresados es: {promedio}");
            Console.ReadLine();
            */

            /* 6. Escribe un programa que busque un elemento específico dentro de un arreglo de números utilizando un bucle for y muestre un 
             * mensaje indicando si el elemento fue encontrado o no.
             */
            // Definir un arreglos de números
            int[] num7 = { 1, 5, 8, 13, 17, 21, 26 };
            // Solcitar al usuario que ingrese el número  a buscar
            Console.WriteLine("Ingrese el número a buscar en el arreglo: ");
            int numBuscar = int.Parse(Console.ReadLine());
            // Variable para  indicar si el elmento fue encontrado
            bool encontrado = false;
            // Bucle para encontrar el elemento en el arreglo
            for (int i = 0; i < num7.Length; i++)
            {
                if (num7[i] == numBuscar)
                {
                    encontrado = true;
                    break;
                }
            }
            // Mensaje si el elmento fue encontrado o no
            if (encontrado)
            {
                Console.WriteLine($"El número {numBuscar} fue encontrado en el arrego ");
            }
            else
            {
                Console.WriteLine($"El número {numBuscar} no fue encontrado en el arrego ");
            }
            Console.ReadKey();
            
        }
    }
}