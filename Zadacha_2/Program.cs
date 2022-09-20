/*// Необходимо сгенерировать случайное трехзначное число и удалить вторую цифру этого числа
int number = new Random().Next(100, 1000);
int number1 = number / 100;
int number3 = number % 10;
Console.Write($"Сгенерировали число {number}, Число без второй цифры {number1}{number3}");*/

//Второй вариант решения этой задачи:

int number = new Random().Next(100, 999); //Вводим диапазон получения случайных чисел.
int number1 = number / 100; // первое число
int number2 = number % 10; // Нахожу 
int result = number * 10 + number2;

Console.WriteLine(number);

Console.WriteLine($"Получили число {result} ");

Console.WriteLine("Получили число вторым способом " + (number1 * 10 + number2));

