class Hand
{
    private List<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public int GetTotalValue()
    {
        int total = 0;
        int aceCount = 0;

        foreach (Card card in cards)
        {
            if (card.Rank == Rank.Ace)
            {
                aceCount++;
            }
            total += card.GetValue();
        }

        while (total > 21 && aceCount > 0)
        {
            total -= 10;
            aceCount--;
        }

        return total;
    }
}