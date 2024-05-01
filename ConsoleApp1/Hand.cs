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

        //손에 있는 모든 카드의 값을 더한다.
        foreach (Card card in cards)
        {
            if (card.Rank == Rank.Ace)
            {
                //Ace체크
                aceCount++;
            }
            total += card.GetValue();
        }

        //전체가 21보다 크고 에이스가 있다면
        //에이스를 1로 취급
        while (total > 21 && aceCount > 0)
        {
            total -= 10;
            aceCount--;
        }

        return total;
    }
    public void PrintHand()
    {
        foreach (Card card in cards)
        {
            Console.WriteLine("현재 가지고 있는 카드 종류 : " + card.ToString());
        }
    }
}