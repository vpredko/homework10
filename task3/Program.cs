int SumNumbers(int start, int end)
{
    if (start == 0)
    {
        return end+1;
    }
    if (start > 0 && end == 0)
    {
        return SumNumbers(start-1,1);
    }
    if (start >0 && end>0)
    {
        return SumNumbers(start-1, SumNumbers(start, end-1));
    }
    {
        return 0;
    }
}
Console.WriteLine ("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(m,N));
