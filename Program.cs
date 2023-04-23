// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write(", ");
        }
        Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

string[] arrayLessThree(string[] initArray)
{
    string[] resArray = new string[initArray.Length];  
    int indexResArray = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= 3)
        {
           resArray[indexResArray] = initArray[i]; 
           indexResArray++; 
        }

    }
    Array.Resize(ref resArray, indexResArray);
    return resArray;
}

string[] initialArray = new string[4] {"hello", "2", "world", ":-)"};

string[] resultArray = arrayLessThree(initialArray);
PrintArray(resultArray);

initialArray = new string[4] {"1234", "1567", "-2", "computer science"};

resultArray = arrayLessThree(initialArray);
PrintArray(resultArray);

initialArray = new string[3] {"Russia", "Denmark", "Kazan"};

resultArray = arrayLessThree(initialArray);
PrintArray(resultArray);