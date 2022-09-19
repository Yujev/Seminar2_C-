/* Задача №3.
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно
*/

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number2 % number1 == 0) 
{
    Console.WriteLine("Второе число кратное первому: ");
}
else 
{
int number2 = number1 = n
Console.WriteLine("Остаток от деления", number2 % number1);
}
