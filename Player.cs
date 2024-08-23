class Player
{
    private string name;

    private Hand hand;

    public Player(string name)
    {
        this.name = name;
        hand = new Hand(new List<Card>());
    }
    public string GetName()
    {
        return name;
    }
    public Hand GetHand()
    {
        return hand;
    }

    public void Deal() {
        for (int i = 0; i < 4; i++)
        {
            hand.AddCard(Deque.Take());
        }
    }
}