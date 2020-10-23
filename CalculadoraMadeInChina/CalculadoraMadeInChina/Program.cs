using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageAddMenu()
        {
            while(true)
            {
                UserInterface.PrintAddMenu();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);
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

