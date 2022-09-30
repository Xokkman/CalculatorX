{
    while (true)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1: //сложение
                {
                    Console.WriteLine ("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine ("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(b + c);
                    break;
                }
            case 2: //вычитание
                {
                    Console.WriteLine ("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine ("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(b - c);
                    break;
                }
            case 3: //умножение
                {
                    Console.WriteLine ("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine ("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(b * c);
                    break;
                }
            case 4: //деление
                {
                    Console.WriteLine ("Введите первое число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine ("Введите второе число");
                    double c = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine(b / c);
                    break;                                 
                }
            case 5: //возвести число в степень
                {
                    Console.WriteLine ("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine ("Введите степень, в которую хотите возвести число");
                    double N = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Math.Pow(b,N));
                    break;
                }
            case 6: //найти квадратный корень из числа
                {
                    Console.WriteLine ("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine (Math.Sqrt(b));
                    break;
                }
            case 7: //найти 1 процент от числа
                {
                    Console.WriteLine ("Введите первое число");
                    double b = Convert.ToDouble (Console.ReadLine());

                    Console.WriteLine ("Введите процент от числа");
                    double prots = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine((b / 100) * prots);
                    break;
                }
            case 8: //найти факториал из числа
                {
                    Console.WriteLine ("Введите число");
                    double b = Convert.ToDouble(Console.ReadLine());

                    int factorial = 1;
                    for (int i = 2; i <= b; i++) 
                    {
                        factorial *= i;
                    }
                    Console.WriteLine(factorial);
                    break;
                }
            case 9: //выйти из программы
                {
                    Environment.Exit(0);
                }
                break;
        }
        Console.WriteLine (" Введите операцию ещё раз");
    }
}