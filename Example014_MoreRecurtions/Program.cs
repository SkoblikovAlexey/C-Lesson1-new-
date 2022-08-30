// string NumbersFor(int a, int b)   // 10 9 8 7 6 5 4 3 2 1
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <=b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(10, 1));
// Console.WriteLine(NumbersRec(1, 10));

// =====================================================

// string NumbersFor(int a, int b)   // 1 2 3 4 5 6 7 8 9 10
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// string NumbersRec(int a, int b)
// {
//     if (a <=b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// =====================================================

// int SumFor(int n) // сумма от 1 до n
// {
//     int result = 0;
//     for (int i = 0; i <= n; i++)
//     {
//         result += i;
//     }
//     return result;
// }
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n-1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// =====================================================

// int FactorialFor(int n) // факториал числа
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }
// int FactorialRec(int n)
// {
//     if (n == 0 || n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// =====================================================

// int PowerFor(int a, int n) // Вычислить a в степени n;
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// int PowerRec(int a, int n)
// { // return n == 0 ? 1 : PowerRec(a, n - 1) *= a; //<--сокращенная запись
//     if(n == 0) return 1;
//     else return PowerRec(a, n-1) * a;
// }
// int PowerRecMath(int a, int n) // улучшенная рекурсия, которая уменьшает количество итераций вызова рекурсии и соответственно умножений
// {
//     if(n == 0) return 1;
//     else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

// =====================================================

// Найти все возможные варианты буквосочетаний из заданных букв и заданной длины буквосочетания

// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[3]);


// =====================================================

// char[] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
//     }
// }