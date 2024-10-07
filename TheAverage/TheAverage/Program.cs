using System;

namespace TheAverage
{
    internal class Program

    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double summ;
            while (true)
            {
                Console.WriteLine("Выберите номер задания:");
                int ew = Convert.ToInt32(Console.ReadLine());
                if(ew == 1)
                {
                    //11111111111
                    Console.WriteLine("Enter the First number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Third number: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Four number: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    summ = Convert.ToDouble(a + b + c + d) / 4;
                    Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: " + summ);
                }else if(ew == 2)
                {
                    Console.WriteLine("Введите два числа:\n");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Вы ввели два числа: {a} и {b}");
                    Console.WriteLine("Какое действие выполнить?");
                    Console.WriteLine("1. Сложение");
                    Console.WriteLine("2. Вычитание");
                    Console.WriteLine("3. Умножение");
                    Console.WriteLine("4. Деление");
                    Console.WriteLine("5. Нахождение остатка\n");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine($"Результат: {a} + {b} = {a + b}");
                            break;
                        case 2:
                            Console.WriteLine($"Результат: {a} - {b} = {a - b}");
                            break;
                        case 3:
                            Console.WriteLine($"Результат: {a} * {b} = {a * b}");
                            break;
                        case 4:
                            Console.WriteLine($"Результат: {a} / {b} = {a / b}");
                            break;
                        case 5:
                            Console.WriteLine($"Результат: {a} % {b} = {a % b}");
                            break;
                    }
                }else if(ew == 3)
                {
                    Console.WriteLine("Выберите шкалу вводимой температуры:");
                    Console.WriteLine("1. Цельсий");
                    Console.WriteLine("2. Кельвин");
                    Console.WriteLine("3. Фаренгейт");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите показатель температура (градусы):");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации:");
                    Console.WriteLine("1. Цельсий");
                    Console.WriteLine("2. Кельвин");
                    Console.WriteLine("3. Фаренгейт");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            if (c == 1)
                            {
                                Console.WriteLine("Вы выбрали: Цельсий->Цельсий");
                                Console.WriteLine("Результат конвертации: " + b);
                            }
                            else if (c == 2)
                            {
                                Console.WriteLine("Вы выбрали: Цельсий->Кельвин");
                                Console.WriteLine("Результат конвертации: " + (b + 273.15));
                            }
                            else if (c == 3)
                            {
                                Console.WriteLine("Вы выбрали: Цельсий->Фаренгейт");
                                Console.WriteLine("Результат конвертации: " + ((b - 273.15) * 9 / 5 + 32));

                            }
                            break;
                        case 2:
                            if (c == 1)
                            {
                                Console.WriteLine("Вы выбрали: Кельвин->Цельсий");
                                Console.WriteLine("Результат конвертации: " + (b - 273.15));
                            }
                            else if (c == 2)
                            {
                                Console.WriteLine("Вы выбрали: Кельвин->Кельвин");
                                Console.WriteLine("Результат конвертации: " + b);
                            }
                            else if (c == 3)
                            {
                                Console.WriteLine("Вы выбрали: Кельвин->Фаренгейт");
                                Console.WriteLine("Результат конвертации: " + ((b - 273.15) * 9 / 5 + 32));
                            }
                            break;
                        case 3:
                            if (c == 1)
                            {
                                Console.WriteLine("Вы выбрали: Фаренгейт->Цельсий");
                                Console.WriteLine("Результат конвертации: " + ((b - 32) * 5 / 9));
                            }
                            else if (c == 2)
                            {
                                Console.WriteLine("Вы выбрали: Фаренгейт->Кельвин");
                                Console.WriteLine("Результат конвертации: " + ((b - 32) * 5 / 9 + 273.15));
                            }
                            else if (c == 3)
                            {
                                Console.WriteLine("Вы выбрали: Фаренгейт\"->Фаренгейт");
                                Console.WriteLine("Результат конвертации: " + b);
                            }
                            break;
                    }
                }else if(ew == 4)
                {
                    Console.WriteLine("Введите путь:");
                    string strrr = Console.ReadLine();
                    string[] partsee = strrr.Split("/");
                    Console.WriteLine(partsee[partsee.Length - 1]);
                }else if(ew == 5)
                {
                    int index = 0;
                    Console.WriteLine("Введите предложение:");
                    string s = Console.ReadLine();
                    string[] ss = s.Split(' ');
                    int max = ss[0].Length;
                    for (int i = 0; i < ss.Length; i++)
                    {
                        if (max < ss[i].Length)
                        {
                            max = ss[i].Length;
                            index = i;
                        }
                    }

                    Console.WriteLine("Самое длинное слово: " + ss[index]);
                }else if(ew == 6)
                {
                    Console.WriteLine("Введите значения для первого массива через пробел:");
                    string strr = Console.ReadLine();
                    string[] firstArrey = strr.Split(' ');

                    Console.WriteLine("Введите значения для второго массива через пробел:");
                    strr = Console.ReadLine();
                    string[] secondArrey = strr.Split(' ');
                    Console.Write("Результат: ");
                    for (int i = 0; i < firstArrey.Length; i++)
                    {
                        Console.Write($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                    }
                }else if(ew == 7)
                {
                    Console.WriteLine("Введите пять чисел:");
                    string stre = Console.ReadLine();
                    string[] partse = stre.Split(" ");
                    int suMax = -111111111;
                    int suMin = 11111110;
                    foreach (string i in partse)
                    {
                        if (suMax < Convert.ToInt32(i))
                        {
                            suMax = Convert.ToInt32(i);
                        }
                        if (suMin > Convert.ToInt32(i))
                        {
                            suMin = Convert.ToInt32(i);
                        }
                    }
                    Console.WriteLine("Максимальное число: " + suMax);
                    Console.WriteLine("Минимальное число: " + suMin);
                }else if(ew == 8)
                {
                    Console.WriteLine("Введите количество ступеней:");
                    int steps = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");

                    string pyromid = "";
                    for (int i = 1; i <= steps; i++)
                    {
                        pyromid += i;
                        Console.WriteLine(pyromid);
                    }
                }else if(ew == 9)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.Write($"{1} x {j} = {i * j}\t");
                        }

                        Console.WriteLine();
                    }

                }else if(ew == 10)
                {
                    int[] atr = [-1, 2, -3, 4, 5, 6, 12];
                    int summm = 0;
                    for(int i = 0; i < atr.Length; i++)
                    {
                        if(atr[i] >= 0)
                        {
                            summm += atr[i];
                        }
                    }
                    Console.WriteLine("Сумма всех положительных элементов: " + summm);
                    summm = 0;
                    for (int i = 0; i < atr.Length; i++)
                    {
                        if (atr[i] > 1 && atr[i] < 10)
                        {
                            summm += atr[i];
                        }
                    }
                    Console.WriteLine("Найдите сумму тех элементов этого списка, которые больше единицы и меньше десяти: " + summm);
                    summm = 0;
                    for (int i = 0; i < atr.Length; i++)
                    {
                        summm += atr[i];
                    }
                    Console.WriteLine("Найдите сумму элементов этого списка: " + summm);
                }
                Console.ReadKey();
                Console.Clear();

            }
            



        }
    }
}
