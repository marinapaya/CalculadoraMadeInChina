using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class ManageUtils
    {
        public static int ReadInteger(string Message)
        {
            while (true)
            {
                try
                {
                System.Console.WriteLine(Message);
                string line = System.Console.ReadLine();
                int number = System.Convert.ToInt32(line);
                return number;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("Número no valido");
                }
            }
        }
    }
}
