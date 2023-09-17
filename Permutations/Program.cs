using Permutations;


class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, int> s3 = new Dictionary<int, int>();
        foreach (var s in Permutation.S(3))
        {
            if (!s3.ContainsKey(s.GetOrder()))
                s3[s.GetOrder()] = 0;
            s3[s.GetOrder()]++;
        }




        Dictionary<int, int> s4 = new Dictionary<int, int>();
        foreach (var s in Permutation.S(4))
        {
            if (!s4.ContainsKey(s.GetOrder()))
                s4[s.GetOrder()] = 0;
            s4[s.GetOrder()]++;
        }

        foreach (var pv in s3)
            Console.WriteLine($"{pv.Key}: {pv.Value}");

        Console.WriteLine("______________________");
        foreach (var pv in s4)
            Console.WriteLine($"{pv.Key}: {pv.Value}");

    }
    //Amogus a = new Amogus(new Permutation(2, 1, 3), new Permutation(3, 1, 2, 4), 3, 4);
        //Console.WriteLine(a.GetOrder());

        /*
        List<Amogus> list = new List<Amogus>();
        foreach (var s1 in Permutation.S(3))
        {
            foreach (var s2 in Permutation.S(4))
            {
                list.Add(new Amogus(s1, s2, 0, 4));
                list.Add(new Amogus(s1, s2, 1, 4));
                list.Add(new Amogus(s1, s2, 2, 4));
                list.Add(new Amogus(s1, s2, 3, 4));
                list.Add(new Amogus(s1, s2, 4, 4));
            }
        }

        int counter = 0;
        foreach(var x in list)
            if (x.GetOrder() == 6)
                counter++;
        Console.WriteLine(counter);
    }
    */
}

class Amogus
{
    private Permutation p1, p2;
    private int a;
    private int m;

    public Amogus(Permutation p1, Permutation p2, int a, int m)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.a = a;
        this.m = m;
    }

    public int GetOrder()
    {
        int counter = 1;
        Permutation v1 = p1.Copy();
        Permutation v2 = p2.Copy();
        int temp = a;
        while (v1 != Permutation.Id(v1.GetLength()) || v2 != Permutation.Id(v2.GetLength()) || temp != 0)
        {
            // Console.WriteLine($"{v1}: {v1 == Permutation.Id(3)}");
            // Console.WriteLine($"{v2}: {v2 == Permutation.Id(4)}");
            // Console.WriteLine(temp);
            // Console.WriteLine("_____________");
            v1 = v1 * p1;
            v2 = v2 * p2;
            temp += a;
            temp = temp % m;
            counter++;
        }

        return counter;
    }
}