using System.Text;

Task1();
Task2();
Task3();
Task4();
Task5();
static void Task1()
{
    //Заменить в строке все вхождения 'test' на 'testing'.Удалить из текста все
    //символы, являющиеся цифрами.

    Console.Write("Введите строку: ");
    string str = Console.ReadLine();

    int index = str.IndexOf("test");

    if (index == -1)
    {
        Console.WriteLine("В строке не обнаружен текст \"test\"!");
    }
    else 
    {
        str = str.Replace("test", "testing");

        Console.WriteLine("Строка после замены \"test\" на \"testing\": " + str);
    }
   
    StringBuilder result = new StringBuilder();

    foreach (char c in str)
    {
        if (!char.IsDigit(c))
        {
            result.Append(c);
        }
    }
    if (str.Length == result.Length)
    {
        Console.WriteLine("В строке не обнаружены цифры, результирующая строка: " + result.ToString());
    }
    else
    {
        Console.WriteLine("Строка после удаления цифр: " + result.ToString());
    }
    
}

static void Task2()
{
    //Используя метод вывода значения в консоль, выполните конкатенацию слов и
    //выведите на экран следующую фразу:
    //Welcome to the TMS lesons.
    //Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome".
    //Не забывайте о пробелах после каждого слова

    string[] words = new string[] { "Welcome", "to", "the", "TMS", "lessons" };
    Console.WriteLine("Конкатенация: " + string.Concat(words[0], " ", words[1], " ", words[2], " ", words[3], " ", words[4]));

    Console.WriteLine("JOIN: " + string.Join(" ", words)); //Не конкатенация, просто захотелось пощупать string.Join
}

static void Task3()
{
    //Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
    //Необходимо найти в данной строке "abc", записав всё что до этих символов в первую
    //переменную, а также всё, что после них во вторую.
    //Результат вывести в консоль.

    string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";

    string searchWord = "abc";
    int indexOfSearchWord = str.IndexOf(searchWord);

    //Первый способ:
    string newStr1 = str.Remove(indexOfSearchWord);
    string newStr2 = str.Remove(0, indexOfSearchWord + 3);
    Console.WriteLine("Первый способ: " + newStr1 + newStr2);

    //Второй способ:
    string newStr1Sub = str.Substring(0, indexOfSearchWord);
    string newStr2Sub = str.Substring(indexOfSearchWord + 3);
    Console.WriteLine("Второй способ: " + newStr1Sub + newStr2Sub);
}

static void Task4()
{
    //Дана строка: Плохой день.
    //Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо
    //используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
    //Заменить последний "!" на "?"

    string str = "Плохой день";

    string strAfterSubstring = str.Substring("плохой".Length);

    string strForInsert = "Хороший!!!!!!!!!";
    strForInsert = strForInsert.Insert("хороший".Length, strAfterSubstring);

    int lastIndex = strForInsert.LastIndexOf('!');
    string result = strForInsert.Substring(0, lastIndex);
    Console.WriteLine(result + '?');
}

static void Task5()
{
    //Написать программу со следующим функционалом:
    //На вход передать строку(будем считать, что это номер документа).
    //Номер документа имеет формат xxxx - yyy - xxxx - yyy - xyxy, где x — это число,
    //а y — это буква.

    Console.WriteLine("Введите номер документа в формате xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква: ");
    string str = Console.ReadLine(); // Не успела сделать проверку на корректность ввода от пользователя

    Task5_1(str);
    Task5_2(str);
    //Task5_3(str); - НЕ УСПЕЛА
    //Task5_4(str); - НЕ УСПЕЛА
    Task5_5(str);
    Task5_6(str);
    Task5_7(str);
}

static void Task5_1(string strInput)
{
    //Вывести на экран в одну строку два первых блока по 4 цифры.

    //Первый способ:
    Console.WriteLine("Два первых блока по 4 цифры первый способ: " + strInput.Substring(0, 4) + " " + strInput.Substring(9, 4));

    //Второй способ:
    string[] blocks = strInput.Split(new char[] { '-' });
    Console.WriteLine("Два первых блока по 4 цифры второй способ: " + blocks[0] + " " + blocks[2]);
}

static void Task5_2(string strInput)
{
    //Вывести на экран номер документа, но блоки из трех букв заменить
    //на ***(каждая буква заменятся на *).

    string[] blocks = strInput.Split(new char[] { '-' });
    blocks[1] = blocks[3] = "***";
    string result = string.Join("-", blocks);
    Console.WriteLine("Блоки из трех букв заменены на ***: " + result);
}

static void Task5_3(string strInput)
{
    //Вывести на экран только одни буквы из номера документа в
    //формате yyy/ yyy / y / y в нижнем регистре.

    //НЕ УСПЕЛА
}

static void Task5_4(string strInput)
{
    //Вывести на экран буквы из номера документа в формате
    //"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
    //класса StringBuilder).

    //НЕ УСПЕЛА
}

static void Task5_5(string strInput)
{
    //Проверить содержит ли номер документа последовательность abc и
    //вывети сообщение содержит или нет(причем, abc и ABC считается
    //одинаковой последовательностью)

    int index = strInput.ToLower().IndexOf("abc");
    if (index == -1)
    {
        Console.WriteLine("Номер документа НЕ содержит последовательность \"abc\"");
    }
    else
    {
        Console.WriteLine("Номер документа содержит последовательность \"abc\"");
    }
}

static void Task5_6(string strInput)
{
    //Проверить начинается ли номер документа с последовательности
    //555

    if (strInput.StartsWith("555"))
    {
        Console.WriteLine("Номер документа начинается с последовательности \"555\"");
    }
    else
    {
        Console.WriteLine("Номер документа НЕ начинается с последовательности \"555\"");
    }
}

static void Task5_7(string strInput)
{
    //Проверить заканчивается ли номер документа на
    //последовательность 1a2b.

    if (strInput.EndsWith("1a2b"))
    {
        Console.WriteLine("Номер документа заканчивается на последовательность \"1a2b\"");
    }
    else
    {
        Console.WriteLine("Номер документа НЕ заканчивается на последовательность \"1a2b\"");
    }
}