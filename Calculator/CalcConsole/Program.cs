using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //calc.exe sum 1 2
            double a = 0;
            double b = 0;
            string oper = "";
            int kol_arg = args.Count();
            if (kol_arg > 0)
            {
                oper = args[0].Trim();
                a = Convert.ToDouble(args[1].Trim());
                if (kol_arg > 2)
                {
                    b = Convert.ToDouble(args[2].Trim());
                }

                switch (oper)
                {
                    case "sum":
                        Console.WriteLine($"sum {a} {b} = {a + b}");
                        break;
                    case "sub":
                        Console.WriteLine($"sub {a} {b} = {a - b}");
                        break;
                    case "multi":
                        Console.WriteLine($"multi {a} {b} = {a * b}");
                        break;
                    case "div":
                        if (b != 0)
                        {
                            Console.WriteLine($"div {a} {b} = {a / b}");
                            break;
                        }
                        else Console.WriteLine("Деление на ноль невозможно");
                        break;
                    case "pow":     //возведение в степень                  
                        Console.WriteLine($"{a} ^ {b} = " + (long)Math.Pow(a, b));
                        break;
                    case "sqrt":     //вычисление квадратного корня                  
                        Console.WriteLine($"sqrt({a}) = " + (long)Math.Round(Math.Sqrt(a)), 3);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Выберите операцию, которую Вы хотели бы совершить:");
                Console.WriteLine("Если хотите выполнить операцию СУММЫ, нажмите 1");
                Console.WriteLine("Если хотите выполнить операцию РАЗНОСТИ, нажмите 2");
                Console.WriteLine("Если хотите выполнить операцию УМНОЖЕНИЯ, нажмите 3");
                Console.WriteLine("Если хотите выполнить операцию ДЕЛЕНИЯ, нажмите 4");
                Console.WriteLine("Если хотите выполнить операцию КВАДРАТНОГО КОРНЯ, нажмите 5");
                Console.WriteLine("Если хотите выполнить операцию ВОЗВЕДЕНИЯ В СТЕПЕНЬ, нажмите 6");
                oper=Console.ReadLine();

                switch (oper)
                {
                    case "1":
                        Console.WriteLine("Введите первое слагаемое");
                        Double.TryParse(Console.ReadLine(),out a);
                        Console.WriteLine("Введите второе слагаемое");
                        Double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine($"Сумма {a} и {b} = {a + b}");
                        break;
                    case "2":
                        Console.WriteLine("Введите уменьшаемое");
                        Double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("Введите вычитаемое");
                        Double.TryParse(Console.ReadLine(), out b);                       
                        Console.WriteLine($"Разность {a} и {b} = {a - b}");
                        break;
                    case "3":
                        Console.WriteLine("Введите первый множитель");
                        Double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("Введите второй множитель");
                        Double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine($"Произведение {a} на {b} = {a * b}");
                        break;
                    case "4":
                        Console.WriteLine("Введите делимое");
                        Double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("Введите делитель, отличный от нуля");
                        Double.TryParse(Console.ReadLine(), out b);
                        if (b != 0)
                        {
                            Console.WriteLine($"Частное от деления {a} на {b} = {a / b}");
                            break;
                        }
                        else Console.WriteLine("Деление на ноль невозможно");
                        break;
                    case "6":     //возведение в степень      
                        Console.WriteLine("Введите основу");
                        Double.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("Введите степень");
                        Double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine($"Число {a} в {b} степени = " + (long)Math.Pow(a, b));
                        break;
                    case "5":     //вычисление квадратного корня 
                        Console.WriteLine("Введите число");
                        Double.TryParse(Console.ReadLine(), out a);                       
                        Console.WriteLine($"Квадратный корень числа ({a}) = " + (long)Math.Round(Math.Sqrt(a)), 3);
                        break;
                }

                /*Console.WriteLine("Введите операцию и параметры");
                Metka1:
                string inputStr = Console.ReadLine();
                if (inputStr != null)
                {
                    string[] param = inputStr.Split(new char[] {' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int kol_param=param.Count();
                    oper = param[0].Trim();
                    if (kol_param>1)
                    {
                        a = Double.Parse(param[1].Trim());
                        if (kol_param > 2)
                        {
                            b = Double.Parse(param[2].Trim());
                        }
                        switch (oper)
                        {
                            case "sum":
                                Console.WriteLine($"sum {a} {b} = {a + b}");
                                break;
                            case "sub":
                                Console.WriteLine($"sum {a} {b} = {a - b}");
                                break;
                            case "multi":
                                Console.WriteLine($"multi {a} {b} = {a * b}");
                                break;
                            case "div":
                                if (b != 0)
                                {
                                    Console.WriteLine($"div {a} {b} = {a / b}");
                                    break;
                                }
                                else Console.WriteLine("Деление на ноль невозможно");
                                break;
                            case "pow":     //возведение в степень                  
                                Console.WriteLine($"{a} ^ {b} = " + (long)Math.Pow(a, b));
                                break;
                            case "sqrt":     //вычисление квадратного корня                  
                                Console.WriteLine($"sqrt({a}) = " + (long)Math.Round(Math.Sqrt(a)), 3);
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Одной операции недостаточно. Введите операцию и параметры");
                        goto Metka1;
                    }                   
                }*/

            }

           
           

            Console.ReadKey();

            /* if (oper=="sum")
             {
                 Console.WriteLine($"sum {a} {b} = {a+b}");
             }
             if (oper == "sub")
             {
                 Console.WriteLine($"sub {a} {b} = {a - b}");
             }
             if (oper == "multi")
             {
                 Console.WriteLine($"multi {a} {b} = {a * b}");
             }
             if (oper == "div")
             {
                 Console.WriteLine($"div {a} {b} = {a / b}");
             }*/


            /* Console.WriteLine("Ведите первое число");
             int a= Console.Read();

             Console.WriteLine("Ведите второе число");
             int b = Console.Read();

             int c = a + b;
             Console.WriteLine("Сумма равна" + c );*/
        }
    }
}
