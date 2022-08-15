// Виды методов

// Вид 1 (ничего не принимают и ничего не возвращают)

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2 (Ничего не возвращают, но могут принимать аргументы)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1(msg: "Текст", count: 4);
// Method2_1(count: 4, msg: "Новый текст");

// Вид 3( Ничего не принимают, но что-то возвращают)

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);

// Вид 4 (что-то прингимают и что-то возвращают)

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

// Вывод на экран таблицы умножения

// for (int i = 2; i <= 10; i++)
//     {
//         for(int j = 2; j<= 10; j++) {
//             Console.WriteLine($"{i} x {j} = {i * j}");
//         }
//         Console.WriteLine();
//     }

// =========Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

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

// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int array)
{

    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(arr);