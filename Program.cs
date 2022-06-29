using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Mono World");
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i + " number's Even");

            else
                Console.WriteLine(i + " number's odd");
        }



    }
}