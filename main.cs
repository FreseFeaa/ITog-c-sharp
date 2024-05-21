// 1. Дано натуральное число N. Найти сумму его четных делителей.
public class Program
{
    public static void Main()
    {
        int N = 20; // ваше натуральное число

        int sumOfEvenDivisors = GetSumOfEvenDivisors(N);

        Console.WriteLine($"Сумма четных делителей числа {N} равна {sumOfEvenDivisors}");
    }

    // Функция для нахождения суммы четных делителей числа
    public static int GetSumOfEvenDivisors(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0 && i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}

// 2. Дано натуральное число. Определить, какая цифра встречается чаще: 0 или 9.


using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int a = 909120349; // ваше натуральное число
        int popularnumber = Findpopularnumber(a);

        if (popularnumber == 0)
        {
            Console.WriteLine("Цифра 0 встречается чаще");
        }
        else if (popularnumber == 9)
        {
            Console.WriteLine("Цифра 9 встречается чаще");
        }
    }

    // Функция для поиска наиболее часто встречающейся цифры
    public static int Findpopularnumber(int n)
    {
        int[] b = new int[10]; // массив для подсчета встречаемости каждой цифры
        while (n > 0)
        {
            int digit = n % 10; // получаем текущую цифру
            b[digit]++; // увеличиваем счетчик для этой цифры
            n = n / 10; // идем к следующей цифре
        }

        int popularnumber = 0;
        int maxCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (b[i] > maxCount)
            {
                maxCount = b[i];
                popularnumber = i;
            }
        }

        return popularnumber;
    }
}

// 3. Найти сумму -12 + 22 – 32 + 42 – 5 2 + . . . + 402 .

using System;

public class Program
{
    public static void Main()
    {
        int sum = 0;
        int a = 2;
        int n = 1;
        for (int i = 0; a<402; i++) { 
            if (n== 1)
            {
                a = a + 10;
                a = a * -1;
                sum = sum + a;
                n = 0;
            }
            if (n == 0)
            {
                a = a * -1;
                a = a + 10;
                sum = sum + a;
                n = 1;
            }
        }
        Console.WriteLine(sum);


    }
}


// 4. Найти все трехзначные числа, которые делятся на n или содержат цифру n (n вводится с клавиатуры).

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        FindNumbers(n);
    }

    // Функция для поиска всех трехзначных чисел, удовлетворяющих условиям
    public static void FindNumbers(int n)
    {
        for (int i = 100; i <= 999; i++)
        {
            if (i % n == 0 || ContainsDigit(i, n))
            {
                Console.WriteLine(i);
            }
        }
    }

    // Функция для проверки наличия цифры n в числе
    public static bool ContainsDigit(int number, int digit)
    {
        while (number > 0)
        {
            if (number % 10 == digit || number % 10 == -digit) // проверяем как положительную, так и отрицательную цифру
            {
                return true;
            }
            number = number / 10;
        }
        return false;
    }
}

// 5. Дано натуральное число n . Вычислить: P = 2 × 4 × 6 × . . . × (2n)


public class Program
{
    public static void Main()
    {
        int n = 3; // ваше натуральное число n

        long product = CalculateProduct(n);

        Console.WriteLine($"P = {product}");
    }

    // Функция для вычисления произведения четных чисел от 2 до 2n
    public static long CalculateProduct(int n)
    {
        long product = 1;
        for (int i = 1; i <= n; i++)
        {
            product *= 2 * i;
        }
        return product;
    }
}

// 6. Дано вещественное число a. Напечатать все значения n, при которых: 1+1/2+1/3+...+1/n>a 

public class Program
{
    public static void Main()
    {
        double a = 4; // Ваше вещественное число a
    
        int n = 1;
        double sum = 0;
        while (sum <= a)
        {
            sum += 1.0 / n;
            Console.WriteLine($"n = {n}, сумма = {sum}");
            n++;
        }
    }
}

// 7. Дано натуральное число. Определить, является ли разность его максимальной и минимальной цифр четным числом.

using System;

public class Program
{
    public static void Main()
    {
        int number = 37542; 

        int difference = FindMaxminnubDifference(number);

        if (difference % 2 == 0)
        {
            Console.WriteLine("Разность максимальной и минимальной цифры является четным числом");
        }
        else
        {
            Console.WriteLine("Разность максимальной и минимальной цифры НЕ является четным числом");
        }
    }

    public static int FindMaxminnubDifference(int n)
    {
        int maxnub = 0;
        int minnub = 9;
        while (n > 0)
        {
            int digit = n % 10;
            maxnub = Math.Max(maxnub, digit);
            minnub = Math.Min(minnub, digit);
            n = n / 10;
        }
        return maxnub - minnub;
    }
}

// 8. Даны два натуральных числа. Выяснить, в каком из них сумма цифр больше.
using System;

public class Program
{
    public static void Main()
    {
        int num1 = 12345;  
        int num2 = 6789;   
        int sumNum1 = CalculateSum(num1);
        int sumNum2 = CalculateSum(num2);

        if (sumNum1 > sumNum2)
        {
            Console.WriteLine($"Сумма цифр в числе {num1} больше, чем в числе {num2}");
        }
        else if (sumNum1 < sumNum2)
        {
            Console.WriteLine($"Сумма цифр в числе {num2} больше, чем в числе {num1}");
        }
        else
        {
            Console.WriteLine($"Суммы цифр в числах {num1} и {num2} равны");
        }
    }
    public static int CalculateSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}

// 9. Даны шесть различных натуральных чисел. Определить максимальное из них.

using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 45, 13, 876, 391, 1210, 612 };

        int maxNum = numbers.Max(); 
        Console.WriteLine("Максимальное число: " + maxNum);
    }
}


// 10. Даны стороны двух треугольников. Найти сумму их площадей.

using System;

public class Program
{
    public static void Main()
    {
        double A1 = 3;  // сторона треугольника 1
        double B1 = 4;  // сторона треугольника 1
        double C1 = 5;  // сторона треугольника 1

        double A2 = 7;  // сторона треугольника 2
        double B2 = 8;  // сторона треугольника 2
        double C2 = 9;  // сторона треугольника 2

        double area1 = CalculateArea(A1, B1, C1);
        double area2 = CalculateArea(A2, B2, C2);

        double sumOfAreas = area1 + area2;

        Console.WriteLine($"Сумма площадей треугольников: {sumOfAreas}");
    }
    public static double CalculateArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
}

// 11. Вычислить значение выражения (2*5!+3*8!)/(6!+4!), используя функцию для вычисления n!

using System;

public class Program
{
    public static void Main()
    {
        int result = CalculateValue();
        Console.WriteLine("Значение выражения: " + result);
    }
    public static int Fact(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Fact(n - 1);
        }
    }
    public static int CalculateValue()
    {
        int result = (2 * Fact(5) + 3 * Fact(8)) / (Fact(6) + Fact(4));
        return result;
    }
}


// 12. Даны 3 натуральных числа. Определить, у какого из них среднее арифметическое цифр больше

using System;

public class Program
{
    public static void Main()
    {
        int number1 = 123;  // Первое натуральное число
        int number2 = 456;  // Второе натуральное число
        int number3 = 789;  // Третье натуральное число

        double average1 = CalculateSrednee(number1);
        double average2 = CalculateSrednee(number2);          // Здесь много переменных, поэтому я вывожу часто на консоль(чтоб отследить что всер норм))
        double average3 = CalculateSrednee(number3);

        Console.WriteLine("Среднее арифметическое цифр в числе " + number1 + " = " + average1);
        Console.WriteLine("Среднее арифметическое цифр в числе " + number2 + " = " + average2);
        Console.WriteLine("Среднее арифметическое цифр в числе " + number3 + " = " + average3);

        if (average1 > average2 && average1 > average3)
        {
            Console.WriteLine("Среднее арифметическое цифр в числе " + number1 + " больше всего");
        }
        else if (average2 > average1 && average2 > average3)
        {
            Console.WriteLine("Среднее арифметическое цифр в числе " + number2 + " больше всего");
        }
        else if (average3 > average1 && average3 > average2)
        {
            Console.WriteLine("Среднее арифметическое цифр в числе " + number3 + " больше всего");
        }
    }

    // Функция для вычисления среднего арифметического цифр в числе
    public static double CalculateSrednee(int number)
    {
        int sum = 0;
        int count = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            count++;
            number = number / 10;
        }
        return (double)sum / count;
    }
}


// 13. Дан одномерный массив целых чисел. Найти максимальный элемент массива и поменять его местами с первым элементом.

using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 4, 7, 2, 8, 5 }; // одномерный массив целых чисел
        Console.WriteLine("Массив до замены:");
        foreach (var element in array)
        {
            Console.WriteLine(element + " ");
        }

        int maxIndex = Array.IndexOf(array, array.Max()); // Находим индекс максимального элемента
        int temp = array[0]; 
        array[0] = array[maxIndex]; 
        array[maxIndex] = temp; 
        Console.WriteLine("Массив после замены:");
        foreach (var element in array)
        {
            Console.WriteLine(element + " ");
        }
    }
}

// 14. Известно, что в одномерном массиве имеются элементы, равные 5. Определить номер первого из них.


using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 2, 5, 8, 5, 3, 7 }; //  одномерный массив целых чисел

        int index = Array.IndexOf(array, 5); //  индекс первого элемента со значением 5

        if (index != -1)
        {
            Console.WriteLine($"Индекс первого элемента со значением 5: {index}");
        }
        else
        {
            Console.WriteLine("Элемент со значением 5 не найден в массиве");
        }
    }
}


// 15. Дан одномерный массив из четного числа элементов. Поменять местами его первый элемент со вторым, третий с четвертым и т.д.

using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 }; 
        Console.WriteLine("Массив до замены:");
        foreach (var element in array)
        {
            Console.WriteLine(element + " ");
        }
        for (int i = 0; i < array.Length - 1; i += 2)
        {
            int temp = array[i]; 
            array[i] = array[i + 1];
            array[i + 1] = temp; 
        }
        Console.WriteLine("Массив после замены:");
        foreach (var element in array)
        {
            Console.WriteLine(element + " ");
        }
    }
}

// 16. Дан массив, содержащий 10 трехзначных чисел. Заменить каждый элемент массива разностью максимальной и минимальной из его цифр.

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 123, 456, 789, 321, 654, 987, 345, 678, 910, 234 }; //  массив с 10 трехзначных чисел
        Console.WriteLine("Массив до замены:");
        foreach (var element in numbers)
        {
            Console.WriteLine(element + " ");
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            while (number > 0)
            {
                int Num = number % 10;
                maxNum = Math.Max(maxNum, Num);
                minNum = Math.Min(minNum, Num);
                number /= 10;
            }

            numbers[i] = maxNum - minNum;
        }
        Console.WriteLine("Массив после замены:");
        foreach (var element in numbers)
        {
            Console.WriteLine(element + " ");
        }
    }
}

// 17. Дан одномерный массив целых чисел. Напечатать все элементы, следующие за последним, оканчивающиеся цифрой "7". Если элементов, оканчивающихся цифрой "7", в массиве нет, то ни один элемент не должен быть напечатан.

using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 123, 57, 47, 876, 32, 10 }; //  одномерный массив целых чисел

        bool found = false; // Флаг, обозначающий, что найден элемент, оканчивающийся на 7
        int lastIndex = array.Length - 1; //  индекс последнего элемента в массиве

        if (array[lastIndex] % 10 == 7) // оканчивается ли последний элемент на 7
        {
            Console.WriteLine("Последний элемент массива оканчивается на 7");
            return; // Если последний элемент оканчивается на 7, завершаем выполнение программы
        }

        foreach (var element in array)
        {
            if (element % 10 == 7) // Проверка, оканчивается ли элемент на 7
            {
                found = true;
            }
        }

        if (!found) // Если элементов с цифрой 7 в конце нет, то выходим из программы
        {
            Console.WriteLine("В массиве нет элементов, оканчивающихся на 7");
            return;
        }

        // Выводим все элементы, следующие за последним элементом, оканчивающиеся на 7, исключая само число, оканчивающееся на 7
        bool printNext = false;
        foreach (var element in array)
        {
            if (printNext)
            {
                if (element % 10 != 7) // Проверяем, чтобы само число, оканчивающееся на 7, не выводилось
                {
                    Console.WriteLine(element);
                }
            }
            if (element % 10 == 7)
            {
                printNext = true;
            }
        }
    }
}


// 18. Дан двумерный массив размером n на n, заполненный целыми числами. Все его отрицательные элементы записать в первый одномерный массив, все его четные элементы - во второй, а нечетные - в третий.

using System;

public class Program
{
    public static void Main()
    {
        int n = 3; 
        int[,] matrix = new int[,] { { 1, -2, 3 }, { 4, -5, 6 }, { -7, 8, -9 } };
        var negativeNumbers = new System.Collections.Generic.List<int>();
        var evenNumbers = new System.Collections.Generic.List<int>();
        var oddNumbers = new System.Collections.Generic.List<int>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
               
                int currentNumber = matrix[i, j];
                if (currentNumber < 0)
                {
                    negativeNumbers.Add(currentNumber);
                }
                else if (currentNumber % 2 == 0)
                {
                    evenNumbers.Add(currentNumber);
                }
                else
                {
                    oddNumbers.Add(currentNumber);
                }
            }
        }

        // Выводим содержимое каждого списка
        Console.WriteLine("Отрицательные числа:");
        foreach (var num in negativeNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Четные числа:");
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Нечетные числа:");
        foreach (var num in oddNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

// 19. Дан двумерный массив целых чисел. В каждой его строке найти сумму отрицательных элементов.


using System;

class Program
{
    static void Main()
    {
        int[,] matr = new int[,]
        {
            {1, -2, 3, -4},
            {5, 6, -7, 8},
            {-9, 10, 11, -12}
        };

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] < 0)
                {
                    sum += matr[i, j];
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов в строке {i + 1}: {sum}");
        }
    }
}

// 20. Дан двумерный массив целых чисел. Определить минимальный номер столбца, состоящего только из элементов, больших числа 10 (считать что такой столбец обязательно есть).

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine()); Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите значение для элемента [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int minColumnIndex = -1; bool foundColumn = false;
        for (int j = 0; j < columns; j++)
        {
            bool allGreaterThan10 = true;
            for (int i = 0; i < rows; i++)
            {
                if (array[i, j] <= 10)
                {
                    allGreaterThan10 = false; break;
                }
            }
            if (allGreaterThan10)
            {
                minColumnIndex = j; foundColumn = true;
                break;
            }
        }
        if (foundColumn)
        {
            Console.WriteLine($"Минимальный номер столбца, в котором все элементы больше 10: {minColumnIndex}");
        }
        else
        {
            Console.WriteLine("В массиве нет столбца, в котором все элементы больше 10.");
        }
    }
}

// 21. Дан двумерный массив. Найти строку с максимальной суммой элементов.

using System;
class Program
{
    static void Main()
    {
        int[,] array = {            {1, 2,3},
            {4, 5, 6},            {7, 8, 9}
        };
        int maxSum = int.MinValue; int maxSumR = -1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum > maxSum)
            {
                maxSum = rowSum; maxSumR = i+1;
            }
        }
        Console.WriteLine($"Строка с макс суммой элементов  {maxSumR} ");
    }
}
















