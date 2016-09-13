using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class console_output
    {
        public void Output()
        {
            Console.WriteLine(@"Выберите арифметическое действие: 
             - Умножение (введите *) 
             - Деление (введите /) 
             - Сложение (введите +) 
             - Вычитание (введите -)");
            string deistvie_arifmeticheskoe = Console.ReadLine();
            double znachenie1, znachenie2;
            double result;
            try
            {
                Console.WriteLine(' ');
                Console.WriteLine("Введите первое значение");
                znachenie1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе значение");
                znachenie2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(' ');
                    vichisleniya vic = new vichisleniya();
                    result = vic.vichislenie(znachenie1, znachenie2, deistvie_arifmeticheskoe);
                    Console.WriteLine("Результат: {0}", result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Output();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
