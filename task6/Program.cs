/*Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число a");
int numberA = int.Parse(Console.ReadLine());
 int quotient=numberA;
if (numberA%2==0)
{
  Console.WriteLine($"Число {quotient}  является четным числом");  
}
else
{
    Console.WriteLine($"Число {quotient}  является нечетным числом");
}