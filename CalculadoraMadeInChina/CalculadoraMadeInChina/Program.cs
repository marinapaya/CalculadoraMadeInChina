﻿using System;

namespace CalculadoraMadeInChina
{
    class Program
    {

        public static void ManageAddSubMenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled + number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:

                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
            }
        }

        public static void ManageAddMenu()
        {
            while(true)
            {
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);
                
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadOption();
                if ( option == 0 )
                {
                    break;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    ManageAddSubMenu(result);
                }
            }
        }

        public static void ManageMainMenu()
        {
            bool finished = false;

            while (finished == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine("Opcion no valida");
                        break;
                    case 1:
                        ManageAddMenu();
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 0:
                        finished = true;
                        break;

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

