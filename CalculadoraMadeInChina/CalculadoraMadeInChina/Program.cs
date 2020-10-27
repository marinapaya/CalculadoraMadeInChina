using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        //MANEJOSUBMENUS
        public static int ManageAddSubMenu(int Accumuled)
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled + number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadMenuOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
            }
        }

        public static int ManageSubSubMenu(int Accumuled)
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintSubHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled * number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintSubSubMenu();
                int option = UserInterface.ReadMenuOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
            }
        }

        public static int ManageSubDivMenu(int Accumuled)
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintDivHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled / number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintSubDivMenu();
                int option = UserInterface.ReadMenuOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 1:
                        return 1;
                }
            }
        }

        public static int ManageSubMulMenu(int Accumuled)
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintMulHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled * number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintSubMulMenu();
                int option = UserInterface.ReadMenuOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
            }
        }

        //MANEJOMENUS
        public static void ManageAddMenu()
        {
            while(true)
            {
                System.Console.Clear();
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);
                
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadMenuOption();
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
                    int submenu_option = ManageAddSubMenu(result);
                    if (submenu_option == 0)
                        return;
                }
            }
        }

        public static void ManageSubMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintSubHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 - number2;
                System.Console.WriteLine("El resultado es " + result);

                UserInterface.PrintSubSubMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    break;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    int submenu_option = ManageSubSubMenu(result);
                    if (submenu_option == 0)
                        return;
                }
            }
        }

        public static void ManageMulMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintMulHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 * number2;
                System.Console.WriteLine("El resultado es " + result);

                UserInterface.PrintSubMulMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    break;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    int submenu_option = ManageSubSubMenu(result);
                    if (submenu_option == 0)
                        return;
                }
            }
        }

        public static void ManageDivMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintDivHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 / number2;
                System.Console.WriteLine("El resultado es " + result);
                System.Console.WriteLine("El resto es");

                UserInterface.PrintSubDivMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    break;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    int submenu_option = ManageSubDivMenu(result);
                    if (submenu_option == 0)
                        return;
                }
            }
        }

        public static void ManageMainMenu()
        {
            bool finished = false;

            while (finished == false)
            {
                System.Console.Clear();
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption();
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
                        ManageSubMenu();
                        break;
                    case 3:
                        ManageMulMenu();
                        break;
                    case 4:
                        ManageDivMenu();
                        break;
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

        //MUESTRAMENUPRINCIPAL
        public static void Main(string[] args)
        {
            ManageMainMenu();
        }

    }
} 

