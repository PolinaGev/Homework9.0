int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanRec(m - 1, 1);
    return AkkermanRec(m-1, AkkermanRec(m, n-1));
}
System.Console.WriteLine(AkkermanRec(2,3));