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
            Console.WriteLine(duchessOfRoses.Name + "\n" + dukeOfOxen.Name + "\n");

            Suits mySuit = Suits.Diamonds;

            Suits[] myVals = new Suits[3] { Suits.Spades, Suits.Clubs, mySuit };

            foreach (Suits val in myVals)
            {
                Console.WriteLine(val);
            } 

            void IsAHeart(Suits suit)
            {
                if (suit == Suits.Hearts)
                {
                    Console.WriteLine("You pulled a heart!");
                }
                else
                {
                    Console.WriteLine($"You didn't pull a heart: {suit}");
                }
            }

            IsAHeart(Suits.Oxen);


        }
    }
}
