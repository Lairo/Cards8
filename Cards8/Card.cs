namespace Cards8
{
    class Card
    {
        public string Value { get; set; }
        public Suits Suit { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(string value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

    }
}
