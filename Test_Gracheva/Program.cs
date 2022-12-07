// Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arrayInitial = { "AAAAAA", "BBBBB", "CCCC", "DDD", "EE", "F" }; // Инициализация массива строк

string[] ThreeLettersArray(string[] array)
{
    int count = 0;                     //считаем кол-во строк с нужной длиной
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count]; //Создаем новый массив нужной длины
    int j = 0;                          //Индекс результирующего массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write(String.Join(", ", array));
}

Console.Write("Массив: [");
PrintArray(arrayInitial);
Console.Write("] -> [");
PrintArray(ThreeLettersArray(arrayInitial));
Console.WriteLine("]");

