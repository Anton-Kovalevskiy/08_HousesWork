/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// Решение задачи №15

Console.Write("Введите цифру, обозначающую день недели -> ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1: Console.Write("Этот день рабочий!");
    break;
    case 2: Console.Write("Этот день рабочий!");
    break;
    case 3: Console.Write("Этот день рабочий!");
    break;
    case 4: Console.Write("Этот день рабочий!");
    break;
    case 5: Console.Write("Этот день рабочий!");
    break;
    case 6: Console.Write("Сегодня ВЫХОДНОЙ!");
    break;
    case 7: Console.Write("Сегодня ВЫХОДНОЙ!");
    break;
    default: Console.Write("Введен неверный день недели!");
    break;
}