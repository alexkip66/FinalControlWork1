/*
Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] InputStrArray(string message)
{
    Console.Write(message);
    string[] array = Console.ReadLine()!.Split(' ');
    return array;
}

void PrintArray(string message, string[] array)
{
    Console.WriteLine(message);
    Console.WriteLine(string.Join(" ", array));
}

string[] SelectShort(string[] inpArr)
{
    string[] resArr = new string[0];
    int resInd = 0;

    foreach (string str in inpArr)
    {
        if (str.Length <= 3)
        {
            Array.Resize(ref resArr, resArr.Length + 1);
            resArr[resInd] = str;
            resInd++;
        }
    }
    return resArr;
}

//string[] inputArray = {"Hello", "2", "world", ":-)"};
//string[] inputArray = {"1234", "1567", "-2", "computer science"};
//string[] inputArray = {"Russia", "Denmark", "Kazan"};
//PrintArray("Исходный массив:", inputArray);

string[] inputArray = InputStrArray("Введите элементы массива, разделяя их пробелами: ");
string[] resultArray = SelectShort(inputArray);
PrintArray("Результат:", resultArray);