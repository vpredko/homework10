string PrintNumbersRecusiveType(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    {
        return (start + " " + PrintNumbersRecusiveType(start+1,end));
    }
}
Console.WriteLine ("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbersRecusiveType(m,N));