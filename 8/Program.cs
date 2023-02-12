//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Найдем все четные числа от 1 до любого числа");
Console.WriteLine("Введите любое число, больше 1");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
    if (index % 2 == 0) Console.Write($"{index} ");
index++;
}