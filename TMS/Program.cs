
//FuncTask1();
//FuncTask2();
//FuncTask3();
//FuncTask4();
//FuncTask5();
//FuncTask6();
//FuncTask7();
//FuncTask7_2();

//FuncTask9();
//FuncTask10();
//FuncTask10_2();

//FuncTask12();
//FuncTask13();

void FuncTask1()
{
    //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

    Console.Write("Введите число, которое необходимо возводить в степень: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите степень, в которую необходимо возвести число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    double res = 1;

    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }

    Console.WriteLine("Результат: " + res);
}

void FuncTask2()
{
    //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Числа, которые деляться на введенное число:");

    for (int i = a; i <= 1000; i+= a)
    {
        Console.WriteLine(i);
    }

}

void FuncTask3()
{
    //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 1; i * i < a; i++)
    {
        count++;
    }

    Console.WriteLine("Количество положительных целых чисел, квадрат которых меньше введенного числа = " + count );
}

void FuncTask4()
{
    //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    for (int i = a - 1; i > 0 ; i--)
    {
        if (a % i == 0)
        {
            Console.WriteLine(i);
            return;
        }   
    }
}

void FuncTask5()
{
    //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int start, finish;

    if (a < b)
    {
        start = a;
        finish = b;
    }
    else
    {
        start = b;
        finish = a;
    }

    int result = 0;

    for(int i = start; i <= finish; i++)
    {
        if (i % 7 == 0)
            result += i;   
    }
    Console.WriteLine("Результат суммы всех чисел из диапазона от A до B, которые делятся без остатка на 7 = " + result);
}

void FuncTask6()
{
    //Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
    
    Console.Write("Введите номер числа Фибоначчи: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0)
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }
    if (n == 1 || n == 2)
    {
        Console.WriteLine("Число Фибоначчи = 1");
        return;
    }
    
    int previous = 1;
    int current = 1;
    int result = 0;

    for(int i = 3; i <= n; i++)
    {
        result = previous + current;            
        previous = current;
        current = result;
    }
    Console.WriteLine("Число Фибоначчи = " + result);
    
}

void FuncTask7()
{
    //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < 0 || b < 0)
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }

    while (a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    Console.WriteLine("НОД = " + b);
}

void FuncTask7_2() //Второй способ решения задачи
{
    //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < 0 || b < 0)
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }
    
    int big, small;
    int remainder = 1;

    if (a > b)
    {
        big = a;
        small = b;
    }
    else
    {
        big = b;
        small = a;
    }

    while (remainder != 0)
    {
        remainder = big % small;
        big = small;
        small = remainder;
    }
    Console.WriteLine("НОД = " + big);
}

void FuncTask9() 
{
    //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

    Console.Write("Введите число: ");
    string strNumber = Console.ReadLine();
    int count = 0;

    for (int i = 0; i < strNumber.Length; i++)
    {
        if (i == 0 && strNumber[i] == '-')
            continue;
        
        int num = Convert.ToInt32(strNumber[i].ToString());
        if (num % 2 != 0)
            count++;
    }
    Console.WriteLine("Количество нечетных цифр этого числа = " + count);
}

void FuncTask10()
{
    //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

    Console.Write("Введите число: ");
    string strNumber = Console.ReadLine();
    string result = "";

    for (int i = strNumber.Length - 1; i >= 0 ; i--)
    {
        result += strNumber[i].ToString();
    }
    Console.WriteLine("Зеркальным отображением последовательности цифр заданного числа является " + result);
}

void FuncTask10_2() //Второй способ решения задачи
{
    //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

    Console.Write("Введите число: ");
    string strNumber = Console.ReadLine();
    Console.Write("Зеркальным отображением последовательности цифр заданного числа является ");

    for (int i = strNumber.Length - 1; i >= 0; i--)
    {
        Console.Write(strNumber[i].ToString());
    }
}

void FuncTask12()
{
    //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

    Console.Write("Введите первое число: ");
    string num1 = Console.ReadLine();

    Console.Write("Введите второе число: ");
    string num2 = Console.ReadLine();

    bool result = false;

    for (int i = 0; i < num1.Length; i++)
    {
        if (i == 0 && num1[i] == '-')
            continue;

        for (int j = 0; j < num2.Length; j++)
        {
            if (j == 0 && num2[j] == '-')
                continue;

            if (num1[i] == num2[j])
            {
                result = true;
                break;
            }
        }
        if (result)
        {
            break;
        }
    }
    Console.WriteLine(result ? "Да" : "Нет");
    
}

void FuncTask13()
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0)
    {
        Console.WriteLine("Вы ввели некорректное число");
        return;
    }

    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += 1 + 1d / (i * i);
    }
    Console.WriteLine("Результат = " + result);
}
