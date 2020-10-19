using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("Calculadora Made In China");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("1) Sumar una serie de números");
            System.Console.WriteLine("2) Restar una serie de números");
            System.Console.WriteLine("3) Multiplicar una serie de números");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("5) Raiz cuadrada de un número");
            System.Console.WriteLine("6) Es primo o no");
            System.Console.WriteLine("7) Sumatorio de una serie de números");
            System.Console.WriteLine("0) Salir de la aplicación");
        }
    }
}
