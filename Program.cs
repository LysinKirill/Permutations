using Permutations;
//  Вывод всех подстановок из множества S3
// Обратите внимание, что при выводе подстановк отображается только её нижняя строка
Console.WriteLine("S3:");
foreach (Permutation x in Permutation.S(3))
{
    x.Write();
    Console.WriteLine("____________________________");
}

//  Разные способы задания подстановок
Permutation f = new Permutation(3, 2, 5, 4, 1);
Permutation g = new Permutation(new int[]{4, 1, 2, 3});
Permutation m = Permutation.Parse("1 3 2 4 5");
Permutation id = Permutation.Id(5);     // Тождественная подстановка длины 5;

f.WriteInfo("f");       //  Вывод блока информации о подстановке. Блок будет озаглавлен f
Console.WriteLine("_______________________");
g.WriteInfo();          //  Вывод блока информации о подстановке без названия блока.
Console.WriteLine("_______________________");
id.Write();      //  Просто вывод подстановки
Console.WriteLine("_______________________\n");

Console.Write("m * g = ");
(m * g).Write();    //  Вывод подстановки полученной умножением m на g. Обратите внимание, что реализация алгоритма умножения допускает перемножение подстановок различных длин. Умножение производится справа налево

Console.WriteLine();
//  Способы задания циклов аналогичны таковым для подстановок (т.е. вид Cycle c = ...), кроме Id, который недоступен для циклов


//  TryParse с нами! Юхууу!!! (и для подстановок кстати тоже)
Cycle c;
if (!Cycle.TryParse("1 5 2", out c))
{
    Console.WriteLine("Парсинг пошёл не по плану))))");
}
Console.WriteLine("Цикл C: {0}\n", c);   //  Для циклов переопределён метод ToString(), это значит, что их можно засовывать в Write() и WriteLine(), не преобразуя явно к строке
Console.WriteLine();

Cycle k = new Cycle(7, 2);

//  Циклы можно перемножать с циклами, перестановками и наоборот. Но важно помнить, что вне зависимости от операндов результатом умножения будет подстановка, даже если умножаете 2 цикла
Console.WriteLine("Произведение циклов c и k:");
(c * k).Write();
Console.WriteLine();

//  Любую подстановку можно разложить на циклы:
//  ToCycles() Возвращает строку, содержащую представление подстановки в циклах
Console.WriteLine("f в циклах:");
Console.WriteLine(f.ToCycles());
Console.WriteLine();

//  GetCycles() Возвращает массив составляющих подстановку циклов
Cycle[] cycles = f.GetCycles();
Console.WriteLine("Массив циклов в f");
foreach(Cycle x in cycles)
    Console.WriteLine(x);
Console.WriteLine();