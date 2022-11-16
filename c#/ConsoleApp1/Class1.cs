using System;
using System.Diagnostics.CodeAnalysis;

public class Class1
{
	public Class1()
	{
        bool isTrue = false;
        int Num = 4;
        if (isTrue || Num != 3)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        int counter = 1;
        while (counter < 10)
        {
            Console.WriteLine(counter);
            counter++;
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + 10);
        }
        int sum = 0;
        for (int i = 0; i < 20; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}
