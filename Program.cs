using System.Runtime.Intrinsics.Arm;

namespace Практическая_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oper;
            do {
                Console.WriteLine("Программа COPP-EA120 приветствует Вас и предлагает на выбор выполнение трёх программ. Для этого введите нужно знесение: 1 - \"Угадай число\", 2 - Таблица умножения, 3 - Вывод делителей числа, 4 - выход из программы.");
                oper = Convert.ToInt32(Console.ReadLine());
                switch (oper)
                {
                    case 1:
                        int vvd;
                        Random chsl = new Random(101);
                        int i = chsl.Next();
                        Console.WriteLine("Угадайте число от 0 до 100!");
                        vvd = Convert.ToInt32(Console.ReadLine());
                        while (vvd != i)
                        {
                            if (i > vvd)
                            {
                                Console.WriteLine("Нужно больше!");
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("Нужно меньше!");
                                break;
                            } 
                        }
                        Console.WriteLine("Да! Ты верно отгадал число!");
                        break;
                    case 2:
                        for (int mn1 = 1; mn1 < 10; mn1++)
                            for (int mn2 = 1; mn2 < 10; mn2++)
                                Console.WriteLine("{0}\t", mn1 * mn2);
                        break;
                    case 3:
                        int otv = 1;
                        Console.WriteLine("Введите число, для которого хотите найти делители.");
                        int vvod = Convert.ToInt32(Console.ReadLine());

                            for (int del = 1; del <= vvod / del; del++)
                            {
                                otv = vvod / del;
                            }
                        do
                        {
                            Console.WriteLine(otv);
                        } while (otv != vvod);
                        
                        break;
                }
            } while (oper != 4);
        }
    }
}