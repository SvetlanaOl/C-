// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число №1");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (firstNumber > secondNumber)
{
    Console.WriteLine(max = firstNumber);
}
else
{
    Console.WriteLine(max = secondNumber);
}