class Hand
{
    private List<Card> cards;

    public Hand(List<Card> cards)
    {
        this.cards = cards;
    }
    public List<Card> GetHand()
    {
        return cards;
    }
    public void PrintHand()
    {
        foreach (Card card in cards)
        {
            card.PrintCard();
        }
        
    }
    public void AddCard(Card card)
    {
        cards.Add(card);
    }

}