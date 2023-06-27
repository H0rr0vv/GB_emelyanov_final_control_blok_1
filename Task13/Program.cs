//Задача 13: 
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int val)
{
    if (val / 100 != 0)
    {
        while (val / 1000 != 0)
        {
            val = val / 10;
        }
        return val % 10;
    }
    else 
    {
        return 0; 
    }
   
}

int thirdDigit = ThirdDigit(value);
if (thirdDigit != 0)
{
    Console.WriteLine(thirdDigit);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
