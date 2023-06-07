// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Main();
void Main()
{
    Console.WriteLine("Введите число N..");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine(GetNumberTill(a));

}
int GetNumberTill(int a)
{ 
    if(a==1){return 1;}
    else 
    Console.Write (a+", ");return GetNumberTill(a-1);
}