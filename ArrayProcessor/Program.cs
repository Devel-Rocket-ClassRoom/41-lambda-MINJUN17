using System;

int[] numbers = { 10, 25, 7, 42, 18, 33 };
Console.Write("배열: ");
for(int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}");
    if(i != numbers.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

Func<int[], int> add = (int[] n) =>
{
    int sum = 0;
    for(int i = 0; i < n.Length; i++)
    {
        sum += n[i];
    }
    return sum;
};
Console.WriteLine($"합계: {ProcessArray(numbers, add)}");

Func<int[], int> max = (int[] n) =>
{
    int max = int.MinValue;
    for (int i = 0; i < n.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
};
Console.WriteLine($"최댓값: {ProcessArray(numbers, max)}");

Func<int[], int> min = (int[] n) =>
{
    int min = int.MaxValue;
    for (int i = 0; i < n.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
};
Console.WriteLine($"최솟값: {ProcessArray(numbers, min)}");

Func<int[], int> evenCount = (int[] n) =>
{
    int evenCount = 0;
    for (int i = 0; i < n.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
};
Console.WriteLine($"짝수 개수: {ProcessArray(numbers, evenCount)}");

int ProcessArray(int[] data, Func<int[], int> processpr)
{
    return processpr(data);
}
