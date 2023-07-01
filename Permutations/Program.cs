using Permutations;

Cycle c1 = Cycle.Parse(Console.ReadLine());
Cycle c2 = Cycle.Parse(Console.ReadLine());

Permutation p = c1 * c2;
while (true)
{
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine((p ^ n).ToCycles());
}