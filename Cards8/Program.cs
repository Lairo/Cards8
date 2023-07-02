using System;

namespace Cards8
{
    class Program
    {
        static void Main()
        {
            Card aceOfSpades = new Card("Ace", Suits.Spades);
            Console.WriteLine(aceOfSpades.Name);
            Card duchessOfRoses = new Card("Duchess", Suits.Diamonds);
            Card dukeOfOxen = new Card("Duke", Suits.Hearts);
            Console.WriteLine(duchessOfRoses.Name + "\n" + dukeOfOxen.Name);
        }
    }
}
