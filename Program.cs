//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

/*Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int firstNum = num;

void PrintNumbers(int startNum, int endNum)
{
    System.Console.WriteLine(startNum);
    if (startNum >= endNum)
    {
        return;
    }
    PrintNumbers(startNum + 1, endNum);
}

PrintNumbers(firstNum, num2);*/



//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0) 
    return n + 1;
    
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");*/


//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.


int[] array = new int[] { 6, 7, 4, 3, 8, 0 };

string PrintArray(int[] array)
{
    return string.Join(", ", array);
}

int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");

