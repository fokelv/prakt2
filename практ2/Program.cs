namespace практ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean x = true;
            do
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить:");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Закрыть программу");
                string input = Console.ReadLine();
                int y = Convert.ToInt32(input);
                if (y == 1)
                {
                    Console.WriteLine("Угадайте число от 0 до 100:");
                    Random rnd = new Random();
                    int number = rnd.Next(0, 100);
                    Boolean z = true;
                    do
                    {
                        string input2 = Console.ReadLine();
                        int a = Convert.ToInt32(input2);
                        if (number == a)
                        {
                            Console.WriteLine("Вы угадали число");
                            z = false;
                            break;
                        }
                        else if (number > a)
                        {
                            Boolean z2 = true;
                            do
                            {
                                Console.WriteLine("Надо взять число больше");
                                z2 = false;
                            }
                            while (z2);
                        }
                        else if (number < a)
                        {
                            Boolean z3 = true;
                            do
                            {
                                Console.WriteLine("Надо взять число меньше");
                                z3 = false;
                            }
                            while (z3);
                        }
                    }
                    while (z);
                }
                else if (y == 2)
                {
                    Console.WriteLine("Таблица умножения:");
                    int i, j;
                    for (i = 1; i < 10; i++)
                        for (j = 1; j < 10; j++)
                        {
                            Console.Write(i * j);
                            Console.Write(j != 9 ? "   " : '\n');
                        }
                }
                else if (y == 3)
                {
                    Console.WriteLine("Введите число, чтобы увидеть все его делители.");
                    Console.WriteLine("Чтобы выйти напишите: 0");
                    Boolean z = true;
                    do
                    {
                        string num = Console.ReadLine();
                        int g = Convert.ToInt32(num);
                        Boolean c = true;
                        do
                        {
                            if (g == 0)
                            {
                                c = false;
                                z = false;
                            }
                            else if (g != 0)
                            {
                                Console.WriteLine("Все делители числа:");
                                for (int i = 1; i <= g; i++)
                                    if (g % i == 0)
                                        Console.WriteLine(i);
                                c = false;
                            }
                        }
                        while (c);
                    }
                    while (z);
                }
                else if (y == 4)
                {
                    x = false;
                }

            }
            while (x);
        }
    }
}