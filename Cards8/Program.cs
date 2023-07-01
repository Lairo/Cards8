using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
