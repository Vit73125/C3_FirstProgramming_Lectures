Method1();

Method2("Текст сообщения");
// Именованные аргументы
Method2(msg: "Текст сообщения - Именованные аргументы");

Method21("Текст", 4);
// Именованные аргументы
Method21(count: 4, msg: "Новый текст");

int year = Method3();
Console.WriteLine(year);

string res = Method4(10, "z");
Console.WriteLine(res);

res = MethodFor(10, "a");
Console.WriteLine(res);

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, = сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 2};
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// Цикл for
string MethodFor(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// Вывод таблицы умножения
for (int i = 0; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// Замена символов в строке
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

// МАССИВЫ

// Вывода массива на консоль
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Сортировка выбором
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}