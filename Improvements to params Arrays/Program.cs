PrintNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);

static void PrintNumbers(params int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
