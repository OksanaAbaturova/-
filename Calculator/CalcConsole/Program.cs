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
            var oper = "";
            double x;
            double y;
            var operations = new List<string>()
            {
                "sum", "sub", "div", "multi", "sqrt"
            };
            if (args.Length>0)
            {
                oper = args[0];
                x = Convert.ToDouble(args[1]);
                y = Convert.ToDouble(args[2]);
            }
            else
            {
                Console.WriteLine("Выберите операцию:");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }
                oper = Console.ReadLine();
                Console.WriteLine("Введите данные в одну строку, разделяя числа пробелом");
                var data = Console.ReadLine().Split(' ').Select(d => Convert.ToDouble(d)).ToArray();
                x = data[0];               
                y = data.Length > 1 ? data[1] : 0;                
            }
            Double result = double.NaN;
            Calc calc = new Calc();
            result = calc.Exec(oper, new[] { "10", "20", "10"});
            Console.WriteLine($"{oper}({x}, {y})={result}");
            Console.ReadKey();

            //calc.exe sum 1 2
            /*double a = 0;
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
                
            }*/
            //else
            //{
            /*Console.WriteLine("Выберите операцию, которую Вы хотели бы совершить:");
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
            }*/

            /*Double result = double.NaN;
            Calc calc = new Calc();
            result = calc.Exec(oper, new[] { "10", "20", "10" });*/

            //Console.WriteLine($"{oper}({x},{y})={result}");
            //Console.ReadKey();

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

            //}

        }
    }
}
