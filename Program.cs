using System;

class Program
{
    static void Main(string[] args)
    {
        string name = null;
        Console.WriteLine("Length: " + name.Length); // NullReferenceException potential
    }
}
