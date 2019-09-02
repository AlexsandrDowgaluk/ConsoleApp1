using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;
            
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                
                Console.Write("Введите первое число: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ошибка ввода ");
                    numInput1 = Console.ReadLine();
                }

                
                Console.Write("Введите второе число ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ошибка ввода");
                    numInput2 = Console.ReadLine();
                }

              
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("\ta - Добавить");
                    Console.WriteLine("\ts - Вычесть");
                    Console.WriteLine("\tm - Умножить");
                    Console.WriteLine("\td - Делить");
                    Console.Write("Выберите опцию ");
                
               
               
                string op = Console.ReadLine();
               
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Математическая ошибка.\n");
                    }
                    else Console.WriteLine("Результат:" + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Нажмите q для закрытия приложения ");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;


        }

    }
}
    

