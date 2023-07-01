namespace Permutations;

public class Util
{
    public static int Factorial(int n)
    {
        int k = 1;
        for (int i = 2; i <= n; i++)
            k *= i;
        return k;
    }
    public static int mod(int x, int m) {
        return (x%m + m)%m;
    }
}
