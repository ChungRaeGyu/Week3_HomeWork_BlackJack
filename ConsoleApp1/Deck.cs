class Deck
{
    private List<Card> cards; //카드를 리스트 형식으로 받는다.

    public Deck()
    {
        cards = new List<Card>();
        //모든카드를 덱에 넣는다.
        foreach (Suit s in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(s, r));
            }
        }

        Shuffle();
    }

    public void Shuffle()
    {
        //섞기
        Random rand = new Random();

        for (int i = 0; i < cards.Count; i++)
        {
            int j = rand.Next(i, cards.Count);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card DrawCard()
    {
        //첫번째 카드를 뽑고 그 카드를 삭제한다.
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}