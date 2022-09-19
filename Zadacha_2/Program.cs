// Необходимо сгенерировать случайное трехзначное число и удалить вторую цифру этого числа
int number = new Random().Next(100, 1000);
int number1 = number / 100;
int number3 = number % 10;
Console.Write($"Первое число {number}, Сгенерировали число {number1}{number3}");

