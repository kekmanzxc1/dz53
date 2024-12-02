using System;
//Завдання 1 
/*class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 5, y = 10;
        Console.WriteLine($"To exchange: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After the exchange: x = {x}, y = {y}");

        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"\nTo exchange: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After the exchange: str1 = {str1}, str2 = {str2}");
    }
}
*/
//Завдання 2
using System;

public class Stack<T>
{
    private T[] items;
    private int size;
    private const int DefaultCapacity = 10;

    public Stack()
    {
        items = new T[DefaultCapacity];
        size = 0;
    }

    public void Push(T item)
    {
        if (size == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[size++] = item;
    }

    public T Pop()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }
        return items[--size];
    }

    public T Peek()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }
        return items[size - 1];
    }

    public int Count
    {
        get { return size; }
    }
}

class Program
{
    static void Main()
    {
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        Console.WriteLine($"Top element: {intStack.Peek()}");
        Console.WriteLine($"Number of elements: {intStack.Count}");

        Console.WriteLine($"Delete: {intStack.Pop()}");
        Console.WriteLine($"Top element: {intStack.Peek()}");
        Console.WriteLine($"Number of elements: {intStack.Count}");

        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("Hello");
        stringStack.Push("World");

        Console.WriteLine($"\nTop element: {stringStack.Peek()}");
        Console.WriteLine($"Delete: {stringStack.Pop()}");
        Console.WriteLine($"Top element: {stringStack.Peek()}");
    }
}
