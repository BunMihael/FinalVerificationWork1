// Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше либо равна
//3м символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не 
//рекомендуется пользоватся коллекциями, лучше обойтись
//исключительно массивами.
// ["hello","2","world",":-)"] -> ["2",":-)"]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] ->[]

string[] getFromArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer", "Don" };

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]} ");
}

string[] ArrayLessThenThree(string[] getFromArray)
{
    int count = 0;
    string[] putInArray = new string[getFromArray.Length];
    for (int i = 0; i < getFromArray.Length; i++)
    {
        if (getFromArray[i].Length < 4)
        {
            putInArray[count] = getFromArray[i];
            count++;
        }
    }
    return putInArray;
}