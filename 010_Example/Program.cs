/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
*/
// Решение задачи №10

Console.Write("Введите трёхзначное число ->");
string number = Console.ReadLine();
if (number.Length > 2 && number.Length < 4)
{
    Console.Write(number[1]);
}
else
{
    Console.Write("Введено неверное число!");
}