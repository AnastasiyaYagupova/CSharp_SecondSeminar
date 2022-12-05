/*
Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num = new Random().Next(0,1000000);
Console.WriteLine(num);

if(num>=100)
{
    while(num >= 999)
    {
        num = num / 10;
    }  
num = num % 10;
Console.WriteLine(num);
}

else
{
    Console.WriteLine("Третий цифры нет");
}





 