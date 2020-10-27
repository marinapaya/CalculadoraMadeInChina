using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.DarkCyan;
            System.Console.ForegroundColor = System.ConsoleColor.Black;
            System.Console.WriteLine("Calculadora Made In China");
            System.Console.WriteLine("-------------------------");
            System.Console.ResetColor();
            System.Console.BackgroundColor = System.ConsoleColor.DarkMagenta;
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("1) Sumar una serie de números");
            System.Console.WriteLine("2) Restar una serie de números");
            System.Console.WriteLine("3) Multiplicar una serie de números");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("5) Raiz cuadrada de un número");
            System.Console.WriteLine("6) Es primo o no");
            System.Console.WriteLine("7) Sumatorio de una serie de números");
            System.Console.WriteLine("0) Salir de la aplicación");
        }

        public static void PrintAddHeader()
        {
            System.Console.WriteLine("Suma de Números");
            System.Console.WriteLine("---------------");
        }

        public static void PrintSubHeader()
        {
            System.Console.WriteLine("Resta de Números");
            System.Console.WriteLine("---------------");
        }
        public static void PrintAddSubMenu()
        {
            System.Console.WriteLine("Suma de Números");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Sumar otro número ");
            System.Console.WriteLine("2) Realizar otra suma ");
        }

        public static void PrintSubSubMenu()
        {
            System.Console.WriteLine("Resta de Números");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Restar otro número ");
            System.Console.WriteLine("2) Realizar otra resta ");
        }

        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
           
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch  (System.Exception e)
            {
                return -1;
            }
        }

         public static int ReadMenuoption(int MinMenuOption, int MaxMenuOption)
        {
            while (true)
            { 
                int option = ReadMenuOption();
                if (option >= MinMenuOption && option <= MaxMenuOption)
                    return option;
                else
                System.Console.WriteLine("Opcion fuera de rango");
            }
        }

    }
}

