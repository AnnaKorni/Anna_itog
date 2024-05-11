// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = ["one", "two", "three", "four", "five"];

int size = SizeNewArray(array);
string[] newArray = GetnewArray(array, size);
printArray(array);
System.Console.Write(" → ");
printArray(newArray);


int SizeNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] GetnewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void printArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}




