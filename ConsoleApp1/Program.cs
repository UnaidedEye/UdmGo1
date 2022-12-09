// See https://aka.ms/new-console-template for more information
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0) Console.Write("FizzBuzz ");
    else if (i % 5 == 0) Console.Write("Buzz ");
    else if (i % 3 == 0) Console.Write("Fizz ");
    else Console.Write(i + " ");
    if (i % 10 == 0) Console.WriteLine();
}
