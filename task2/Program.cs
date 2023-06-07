// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Main();
void Main()
{
    Console.WriteLine("Введите число M...");
    int M = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число N...");
    int N = int.Parse(Console.ReadLine()!);
    int sum = ReturnSum(M, N);
    Console.WriteLine(sum);
}
int ReturnSum(int a, int b)
{
    if (a == b) { return b; }
    else return a += ReturnSum(a + 1, b);

}
