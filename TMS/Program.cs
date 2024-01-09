
using System;

OneDementionalArrays();
//TwoDementionalArrays();

static void OneDementionalArrays()
{
    int[] currentArray = CreateOneDemArrayWithRandomNum();
        
    PrintOneDemArray("Сформированный массив: ", currentArray);

    MinElement(currentArray); //Task1 and Task3
    MaxElement(currentArray); //Task2 and Task4
    SumOddIndex(currentArray); //Task5 
    ReversArray((int[])currentArray.Clone()); //Task6
    CountOddElement(currentArray); //Task7
    ChangeHalves((int[])currentArray.Clone()); //Task8
}
    
    static int InputInt(string toShowUser, int min)
    {
        Console.Write(toShowUser);
        string str = Console.ReadLine();
        int result;

        while (!int.TryParse(str, out result) || result < min)
        {
            Console.WriteLine("Вы ввели некорректное значение");
        Console.Write(toShowUser);
        str = Console.ReadLine();
        }
        return result;
    }
    static int[] CreateOneDemArrayWithRandomNum()
    {

        int arrayDimension = InputInt("Укажите количество элементов, в создаваемом массиве (размерность массива): ", 1);

        int[] newArray = new int[arrayDimension];
        Random random = new Random();

        for (int i = 0; i < arrayDimension; i++)
        {
            newArray[i] = random.Next(50);
        }
        return newArray;
    }

    static void PrintOneDemArray(string toShowUser, int[] array)
    {
        Console.Write(toShowUser);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void MinElement(int[] array) //Task1 and Task3
{
        //Найти минимальный элемент массива
        //Найти индекс минимального элемента массива

        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        Console.WriteLine("Минимальный элемент массива = " + array[minIndex]);
        Console.WriteLine("Индекс минимального элемента массива = [" + minIndex + "]");

    }

    static void MaxElement(int[] array) //Task2 and Task4
{
        //Найти максимальный элемент массива
        //Найти индекс максимального элемента массива

        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        Console.WriteLine("Максимальный элемент массива = " + array[maxIndex]);
        Console.WriteLine("Индекс максимального элемента массива = [" + maxIndex + "]");

    }

    static void SumOddIndex(int[] array) //Task5 
{
        //Посчитать сумму элементов массива с нечетными индексами

        int sum = 0;
        for(int i = 1; i < array.Length; i+=2)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма элементов массива с нечетными индексами = " + sum);
    }

    static void ReversArray(int[] array) //Task6
{
        //Сделать реверс массива (массив в обратном направлении)

        int temp;
        int lenght = array.Length;

        for(int i = 0; i < lenght / 2; i++)
        {
            temp = array[i];
            array[i] = array[lenght - 1 - i];
            array[lenght - 1 - i] = temp;
        }
        PrintOneDemArray("Реверс массива: ", array);
    }

    static void CountOddElement(int[] array) //Task7
{
        //Посчитать количество нечетных элементов массива

        int count = 0;

        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] % 2 != 0)
            {
                count++;
            }
        }
        Console.WriteLine("Количество нечетных элементов массива = " + count);
    }

    static void ChangeHalves(int[] array) //Task8
{
        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.

        int temp;
        int a = array.Length % 2 == 0? array.Length / 2 : array.Length / 2 + 1;

        for(int i = 0; i < array.Length / 2; i++)
        {
            temp = array[i];
            array[i] = array[i + a];
            array[i + a] = temp;
        }
        PrintOneDemArray("Массив, в котором поменяли местами первую и вторую половину массива: ", array);
    }

// ---------ЗАДАНИЯ ДЛЯ ДВУМЕРНЫХ МАССИВОВ---------------
static void TwoDementionalArrays()
{
    int[,] currentArray = CreateTwoDemArrayWithRandomNum();

    PrintTwoDemArray("Сформированный массив: ", currentArray);

    MinElementTwoDemArray(currentArray); //Task1 and Task3
    MaxElementTwoDemArray(currentArray); //Task2 and Task4
    MaxAmongNeighborsTwoDemArray(currentArray); //Task5
    ReversTwoDemArray((int[,])currentArray.Clone()); //Task6
    TwoDemArrayTask_8(currentArray); //Task8
}

static int[,] CreateTwoDemArrayWithRandomNum()
{

    int arrayRow = InputInt("Укажите количество строк, в создаваемом массиве: ", 1);
    int arrayColumn = InputInt("Укажите количество столбцов, в создаваемом массиве: ", 1);

    int[,] newArray = new int[arrayRow, arrayColumn];
    Random random = new Random();

    for (int i = 0; i < arrayRow; i++)
    {
        for(int j = 0; j < arrayColumn; j++)
        {
            newArray[i, j] = random.Next(50);
        }
    }
    return newArray;
}

static void PrintTwoDemArray(string toShowUser, int[,] array)
{
    Console.Write(toShowUser + "\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
static void MinElementTwoDemArray(int[,] array) //Task1 and Task3
{
    //Найти минимальный элемент двумерного массива
    //Найти индекс минимального двумерного элемента массива

    int minIndexRow = 0, minIndexColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minIndexRow, minIndexColumn])
            {
                minIndexRow = i;
                minIndexColumn = j;
            }
        }     
    }
    Console.WriteLine("Минимальный элемент массива = " + array[minIndexRow, minIndexColumn]);
    Console.WriteLine("Индекс минимального элемента массива = [" + minIndexRow + ", " + minIndexColumn + "]");
}

static void MaxElementTwoDemArray(int[,] array) //Task2 and Task4
{
    //Найти максимальный элемент двумерного массива
    //Найти индекс максимального двумерного элемента массива

    int maxIndexRow = 0, maxIndexColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > array[maxIndexRow, maxIndexColumn])
            {
                maxIndexRow = i;
                maxIndexColumn = j;
            }
        }
    }
    Console.WriteLine("Максимальны элемент массива = " + array[maxIndexRow, maxIndexColumn]);
    Console.WriteLine("Индекс максимального элемента массива = [" + maxIndexRow + ", " + maxIndexColumn + "]");
}

static void MaxAmongNeighborsTwoDemArray(int[,] array) //Task5
{
    //Найти количество элементов массива, которые больше всех своих соседей одновременно
    int count = 0;
    int leftIndex, rightIndex, topIndex, downIndex;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        topIndex = (i == 0 ? i : i - 1);
        downIndex = (i == array.GetLength(0) - 1 ? i : i + 1);
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            leftIndex = (j == 0 ? j : j - 1);
            rightIndex = (j == array.GetLength(1) - 1 ? j : j + 1);
            bool currentElMax = true;

            for (int l = topIndex; l <= downIndex; l++)
            {
                for (int k = leftIndex; k <= rightIndex; k++)
                {
                    if (array[i, j] < array[l, k])
                    {
                        currentElMax = false;
                        break;
                    }
                }
                if (!currentElMax) break;
            }
            if (currentElMax)
            {
                Console.Write(array[i, j] + " ");
                count++;
            }
        }
    }
    Console.WriteLine("\nКоличество элементов массива, которые больше всех своих соседей одновременно = " + count);
}

static void ReversTwoDemArray(int[,] array) //Task6
{
    //Отразите массив относительно его главной диагонали

    int temp;
    int stop = Math.Min(array.GetLength(0), array.GetLength(1));

    for (int i = 0; i < stop; i++)
    {
        for (int j = 0; j < stop; j++)
        {
            if (i >= j) continue;

            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

    PrintTwoDemArray("Массив, отраженный по главной диагонали: ", array);
}

static void TwoDemArrayTask_8(int[,] array) //Task8
{
    //Дан двухмерный массив A[1..m, 1..n].Написать программу построения одномерного массива B[1..m],
    //элементы которого соответственно равны а) суммам элементов строк, б) произведениям элементов строк,
    //в) наименьшим средних арифметических элементов строк.

    int[] arraySum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] += array[i, j];
        }
    }

    PrintOneDemArray("Массив с суммой элементов строк: ", arraySum);

    int[] arrayMultipl = new int[array.GetLength(0)];

    for (int i = 0;i < arrayMultipl.Length; i++)
    {
        arrayMultipl[i] = 1;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayMultipl[i] *= array[i, j];
        }
    }
    PrintOneDemArray("Массив с произведением элементов строк: ", arrayMultipl);
}
