
//FuncTask1();
//FuncTask2();
//FuncTask3();
//FuncTask4();
//FuncTask5();
//FuncTask6();


void FuncTask1()
{
    //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

    Console.Write("Введите первое число: ");
    float a = Convert.ToSingle(Console.ReadLine());

    Console.Write("Введите второе число: ");
    float b = Convert.ToSingle(Console.ReadLine());

    float res = (a > b) ? (a + b) : (a == b) ? (a * b) : (a - b);
    Console.WriteLine("Результат: " + res);
}

void FuncTask2()
{
    //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

    Console.Write("Введите координату х: ");
    float x = Convert.ToSingle(Console.ReadLine());

    Console.Write("Введите координату у: ");
    float y = Convert.ToSingle(Console.ReadLine());

    if (x == 0 || y == 0)
    {
        Console.WriteLine("Точка находится на координатной оси!");
    }
    else
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой четверти");
        }

        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй четверти");
        }

        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей четверти");
        }
            
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой четверти");
        }     
    }
}

void FuncTask3()
{
    //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.

    Console.Write("Введите первое число: ");
    float a = Convert.ToSingle(Console.ReadLine());

    Console.Write("Введите второе число: ");
    float b = Convert.ToSingle(Console.ReadLine());

    Console.Write("Введите третье число: ");
    float c = Convert.ToSingle(Console.ReadLine());

    float min, midl, max;

    if (a >= b)
    {
        if (a >= c)
        {
            max = a;
            if (b >= c)
            {
                midl = b;
                min = c;
            }
            else
            {
                midl = c;
                min = b;
            }
        }
        else
        {
            max = c;
            midl = a;
            min = b;
        }
    }
    else
    {
        if (a >= c)
        {
            max = b;
            midl = a;
            min = c;
        }
        else
        {
            min = a;
            if (b >= c)
            {
                midl = c;
                max = b;
            }
            else
            {
                midl = b;
                max = c;
            }
        }
    }

    Console.WriteLine($"Отсортированные числа в порядке возрастания: {min}, {midl}, {max}" );
}

void FuncTask4()
{
    //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где A*X*X + B*X + C = 0.

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int D = b * b - 4 * a * c;

    if (D < 0)
    {
        Console.WriteLine("Нет действительных корней");
    }

    else if (D == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"Решением квадратного уравнения является корень Х = {x}");
    }
    else
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"Решением квадратного уравнения являются корни Х1 = {x1} и Х2 = {x2}");
    }

}

void FuncTask5()
{
    //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

    Console.Write("Введите двузначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a < 10 || a > 99)
    {
        Console.WriteLine("Вы ввели некорректное число!");
    }

    else if (a >= 10 && a  <= 19)
    {
        switch (a)
        {
            case 10: Console.WriteLine("Вы ввели число: \"Десять\"");
                break;

            case 11:
                Console.WriteLine("Вы ввели число: \"Одиннадцать\"");
                break;

            case 12:
                Console.WriteLine("Вы ввели число: \"Двенадцать\"");
                break;

            case 13:
                Console.WriteLine("Вы ввели число: \"Тринадцать\"");
                break;

            case 14:
                Console.WriteLine("Вы ввели число: \"Четырнадцать\"");
                break;

            case 15:
                Console.WriteLine("Вы ввели число: \"Пятнадцать\"");
                break;

            case 16:
                Console.WriteLine("Вы ввели число: \"Шестнадцать\"");
                break;

            case 17:
                Console.WriteLine("Вы ввели число: \"Семнадцать\"");
                break;

            case 18:
                Console.WriteLine("Вы ввели число: \"Восемнадцать\"");
                break;

            case 19:
                Console.WriteLine("Вы ввели число: \"Девятнадцать\"");
                break;
        }
    }
    
    else if (a >= 20 && a <= 99)
    {
        int tens = a / 10;

        switch (tens)
        {
            case 2: 
                Console.Write("Вы ввели число: \"Двадцать");
                break;

            case 3:
                Console.Write("Вы ввели число: \"Тридцать");
                break;

            case 4:
                Console.Write("Вы ввели число: \"Сорок");
                break;

            case 5:
                Console.Write("Вы ввели число: \"Пятьдесят");
                break;

            case 6:
                Console.Write("Вы ввели число: \"Шестьдесят");
                break;

            case 7:
                Console.Write("Вы ввели число: \"Семьдесят");
                break;

            case 8:
                Console.Write("Вы ввели число: \"Восемьдесят");
                break;

            case 9:
                Console.Write("Вы ввели число: \"Девяносто");
                break;

        }

        int units = a % 10;

        switch (units)
        {
            case 0:
                Console.WriteLine("\"");
                break;

            case 1:
                Console.WriteLine(" одни\"");
                break;

            case 2:
                Console.WriteLine(" два\"");
                break;

            case 3:
                Console.WriteLine(" три\"");
                break;

            case 4:
                Console.WriteLine(" четыре\"");
                break;

            case 5:
                Console.WriteLine(" пять\"");
                break;

            case 6:
                Console.WriteLine(" шесть\"");
                break;

            case 7:
                Console.WriteLine(" семь\"");
                break;

            case 8:
                Console.WriteLine(" восемь\"");
                break;

            case 9:
                Console.WriteLine(" девять\"");
                break;

        }
    }

}

void FuncTask6()
{
    //Определить, попадает ли точка M(x,y) в круг радиусом r с центром в точке (x0,y0)

    Console.Write("Введите кординату Х0 для центра окружности: ");
    double x0 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите кординату Y0 для центра окружности: ");
    double y0 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите радиус окружности: ");
    double r = Convert.ToDouble(Console.ReadLine());

    if (r <= 0)
    {
        Console.WriteLine("Введен некорректный радиус");
    }
        
    else
    {
        Console.Write("Введите кординату Х для точки: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите кординату Y для точки: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) < Math.Pow(r, 2))
        {
            Console.WriteLine("Точка находится внутри окружности");
        }
            

        else if (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) > Math.Pow(r, 2))
        {
            Console.WriteLine("Точка находится вне окружности");
        }
            

        else
        {
            Console.WriteLine("Точка находится на окружности");
        }
    }

}



