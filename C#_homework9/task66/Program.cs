/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите число M");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int count = userNumberM;
printRange(userNumberM, userNumberN);
void printRange(int Start, int End)
{
    if (Start == End)
    {
        return;
    }
    printRange(Start, End - 1);
    count += End;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {count} ");