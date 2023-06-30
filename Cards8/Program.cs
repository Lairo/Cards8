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
            Card aceOfSpades = new Card("Ace", "Spades");
            Console.WriteLine(aceOfSpades.Name);
            Card duchessOfRoses = new Card("Duchess", "Roses");
            Card dukeOfOxen = new Card("Duke", "Oxen");
            Console.WriteLine(duchessOfRoses.Name + "\n" + dukeOfOxen.Name);
        }
    }
}
