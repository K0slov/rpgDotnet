using System;
using NewDot.src.Entities;

class Program
{
    static void Main(string[] args)
    {
       Wizard champion = new Wizard("icaro", 25, "Wizzard");
       Archer support = new Archer("Chronos", 20, "Archer");

        Console.WriteLine(champion);
        Console.WriteLine(support);
        Console.WriteLine(champion.Attack(9));
        Console.WriteLine(support.Attack(-1));
    }
}