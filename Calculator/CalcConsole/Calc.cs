using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CalcLibrary;
using System.IO;

namespace CalcConsole
{
   public class Calc
    {
        public Calc()
        {
            var Operations = new List<IOperation>();
            var curAssembly = Assembly.GetExecutingAssembly();
            //операции из текущей сборки
            LoadOperations(curAssembly);
            //проверим, каки функции есть у нас в калькуляторе. 
            //var curAssembly=Assembly.GetExecutingAssembly();


            //операции сторонних разработчиков
            var pathExtentions = Path.Combine(Environment.CurrentDirectory, "extensions");
            if (Directory.Exists(pathExtentions))
            {
                var assemblies = Directory.GetFiles(pathExtentions, "*.dll");
                foreach (var filename in assemblies)
                {
                    LoadOperations(Assembly.LoadFile(filename));
                }
            }
            LoadOperations(curAssembly);
        }


            /*var types = curAssembly.GetTypes();

            foreach (var type in types)
            {
                if (type.IsAbstract || type.IsInterface)
                    continue;
                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var obj = Activator.CreateInstance(type) as IOperation;
                    if (obj != null)
                    {
                        Operations.Add(obj);
                    }
                }
            }*/
        

            private void LoadOperations(Assembly assembly)
            {
            var types = assembly.GetTypes();
            var typeOperation = typeof(IOperation);
            foreach (var type in types)
            {
                if (type.IsAbstract || type.IsInterface)
                    continue;
                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var obj = Activator.CreateInstance(type) as IOperation;
                    if (obj != null)
                    {
                        Operations.Add(obj);
                    }
                }
            }
        }

        /*var sumType = typeof(SumOperation);
        sumType.GetMethods();
        sumType.GetInterfaces();*/


    

        private IList<IOperation> Operations;
        //список оперций
        public double Exec(string operationName, string[] args)
        {
            IOperation oper;
            /*bool Func(IOperation it,  string OperationName)
            {
                return it.Name == operationName;
            }*/
            //selsect top 1 *  from Operations where Name-operationName
            /*oper = Operations
                .Where(it => it.Name == operationName)
                .FirstOrDefoult();      //т же самое, что 1 элемент или по умолчанию*/
           
            //найти оперцию в списке операций
            /*foreach (var item in Operations)
            {
                if (item.Name == operationName)
                {
                    oper = item;
                    break;
                }
            }*/
            oper = Operations.FirstOrDefault(it => it.Name == operationName);
            //Console.WriteLine(oper);
            //если не удалось найти - возвращаем Nan
            if (oper == null)
            {
                return double.NaN;
            }
            //иначе
            //вычисляем результат операции
            var result = oper.Exec(args);
            //если в результат  ошибка заполнена
            if (!string.IsNullOrWhiteSpace(result.Error))
            {
                //выводим ее на экран
            }
            else
            {
                //иначе
                //выводим результат
                return result.Result;
            }

            //дефолтное значение
            return double.NaN;
        }

        #region int
        [Obsolete ("Не использовать!", false)]
        public int Sum(int x, int y)
        {
            //return x + y;
            return (int)Sum((double)x, (double)y);
        }

        #endregion

        #region double
        public double Sum (double x, double y)
        {
            return x+y;
        }
        public double Sub(double x, double y)
        {
            return x-y;
        }
        public double Multi(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public double Sqrt(double x)
        {
            return (long)Math.Round(Math.Sqrt(x));
        }
        public double Pow(double x, double y)
        {
            return (long)Math.Pow(x, y);
        }
        #endregion
    }
}
