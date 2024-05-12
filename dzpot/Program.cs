using System;

class Program
{
    static void Main()
    {
        string[] array = { "hello", "world", "123", "45", "six" };
        string[] newArray = CreateNewArray(array);
        PrintArray(newArray);
    }

     static string[] CreateNewArray(string[] array)
    {
        int count = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }
        string[] newArray = new string[count];
        int index = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                newArray[index] = element;
                index++;
            }
        }
        return newArray;

         }

    static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.Write(element + " ");
        }
    }

}