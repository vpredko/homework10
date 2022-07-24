int SumNumbers(int start, int end)
{
    int sum = 0;
    if (start > end)
    {
        return sum;
    }
    {
        sum = sum + start;
        return sum+ SumNumbers(start+1,end);
    }
}
Console.WriteLine ("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(m,N));