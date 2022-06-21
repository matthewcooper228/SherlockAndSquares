
int squares(int a, int b)
{
    return (int)Math.Sqrt(b) - (int)Math.Sqrt(a);
}
int a = 1;
int b = 1000000000;
Console.WriteLine("There are " + squares(a,b) + " perfect squares from " + a + " to " + b + ".");