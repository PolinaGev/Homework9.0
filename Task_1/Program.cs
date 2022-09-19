string GetNaturalsBetweenWithRecursion(int m, int n)
{
  if (m == n) return Convert.ToString(n);
  return m + ", " + GetNaturalsBetweenWithRecursion(m + 1, n);
}
System.Console.WriteLine(GetNaturalsBetweenWithRecursion(1,5));