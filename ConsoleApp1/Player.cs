class Player
{
    public Hand Hand { get; set; }
    public string Name { get; set; }

    public Player()
    {
        Hand = new Hand();
        Name = "Player";
    }

    public Card DrawCardFromDeck(Deck deck)
    {
        Card drawnCard = deck.DrawCard(); //덱클래스에서 뽑은 카드를 drawnCard에 넣는다.
        Hand.AddCard(drawnCard);    //Hand클래스에 뽑은 카드를 더해준다.
        return drawnCard;
    }
    public void MyHand()
    {
        Hand.PrintHand();
    }
}