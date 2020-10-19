using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                { 
                    break;
                }
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opcion no valida");
                }
                else if (option < 0 || option > 7)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opcion no valida, pon un numero entre el 0 y el 7");
                }
            }

            System.Console.WriteLine("Fin del menu principal");
        }


        public static void Main(string[] args)
        {
            ManageMainMenu();
        }

    }
} 

