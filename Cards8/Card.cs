﻿namespace Cards8
{
    class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }

    }
}
