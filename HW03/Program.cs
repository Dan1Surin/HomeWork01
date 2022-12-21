// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("1-Понедельник 2-Вторник 3-Среда 4-Четверг 5-Пятница 6-Суббота 7-Воскресенье");
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number <1 | number > 7)
{
    Console.WriteLine("Неверное число");
}
else
{
    

if ( number <6  )
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной");
}
    Console.ReadLine();
}
