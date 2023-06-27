/* Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


string[] CreateArray(int size)
{
    string[] arr = new string[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    
    Console.Write("]");
}

string[] ShortLenTo3(string[] arr)
{
    int new_size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 3)
        {
            new_size ++;
        }
    }
    string[] shortArr = new string[new_size];
    for (int i = 0; i < arr.Length; i++)
    {
        int j = 0;
        if (arr[i] <= 3)
        {
            shortArr[j] = arr[i];
        }
    }
	return reverseArr;
}




Console.WriteLine($"Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
string[] shortArray = ShortLenTo3(array)


PrintArray(array);
Console.Write(" -> ");
PrintArray(shortArray);