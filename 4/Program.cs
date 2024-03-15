using System;

namespace _4
{
    class Program
    {
        delegate double CalculationDelegate(double x);

        static void Main()
        {
            Console.WriteLine($"Вводьте рядки посл?довно один за одним.\nПоки вони матимуть вигляд 0 x чи 1 x чи 2 x\n" +
                $"(тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа),\n" +
                $"програма обчислюватиме одну з трьох функцiй\n" +
                $"\t0-- sqrt(abs(x))\n" +
                $"\t1-- x ^ 3(Iнакше кажучи, x * x * x)\n" +
                $"\t2-- x + 3, 5\n" +
                $"(згiдно цифри на початку) i виводитиме результат.\n" +
                $"Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить роботу.");

            CalculationDelegate[] calculations = {
            x => Math.Sqrt(Math.Abs(x)),
            x => Math.Pow(x, 3),
            x => x + 3.5
        };
            while (true)
            {
                string[] input = Console.ReadLine().Trim().Split();
                try
                {
                    int comand = Convert.ToInt32(input[0]);
                    double num = Convert.ToInt32(input[1]);
                    var res = calculations[comand](num);
                    Console.WriteLine(res);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ви припустились помилки: {e.Message} \nПрограма завершує свою роботу.");
                    break;
                }
            }
            Console.WriteLine("Дякую за те, що використали програму. Гарного дня!");
        }
    }
}
