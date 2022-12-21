// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// Console.WriteLine("Запишите ваше число");   Пытался в МАССИВ
// int[] number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number[4]);

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 & number > -100)
    {
        Console.WriteLine("Третьего числа нет");
    }
else
{
    if (number<-100) number= number*(-1);

    while (number>999)
{
    number = number / 10;
    //Console.WriteLine(number); 
}
Console.WriteLine($"Третья цифра числа {number % 10}");
Console.ReadLine();    
}


