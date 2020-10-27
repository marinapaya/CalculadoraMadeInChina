using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        //MENUPRINCIPAL
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

        //MENUSUMA
        public static void PrintAddHeader()
        {
            System.Console.WriteLine("Suma de Números");
            System.Console.WriteLine("---------------");
        }

        //MENURESTA
        public static void PrintSubHeader()
        {
            System.Console.WriteLine("Resta de Números");
            System.Console.WriteLine("---------------");
        }

        //MENUMULTIPLICACION
        public static void PrintMulHeader()
        {
            System.Console.WriteLine("Multiplicacion");
            System.Console.WriteLine("---------------");
        }

        //MENUDIVISION
        public static void PrintDivHeader()
        {
            System.Console.WriteLine("DIVISION");
            System.Console.WriteLine("---------------");
        }

        //SUBMENUSUMA
        public static void PrintAddSubMenu()
        {
            System.Console.WriteLine("Suma de Números");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Sumar otro número ");
            System.Console.WriteLine("2) Realizar otra suma ");
        }

        //SUBMENURESTA
        public static void PrintSubSubMenu()
        {
            System.Console.WriteLine("Resta de Números");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Restar otro número ");
            System.Console.WriteLine("2) Realizar otra resta ");
        }

        //SUBMENUMULTIPLICACION
        public static void PrintSubMulMenu()
        {
            System.Console.WriteLine("Multiplicacion de Números");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Multiplicar otro número ");
            System.Console.WriteLine("2) Realizar otra multiplicacion ");
        }
        //SUBMENUDIVISION
        public static void PrintSubDivMenu()
        {
            System.Console.WriteLine("Division de Números");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("0) Salir al menú principal ");
            System.Console.WriteLine("1) Realizar otra division ");
        }


        //MENUDELECTURA
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

