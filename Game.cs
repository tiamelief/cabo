class Game 
{
    private List<Player> players;

    public Game(List<Player> players) 
    {
        this.players = players;
    }

    public void Start() 
    {
        Console.WriteLine("Game started");
        Deque.Shuffle();
        foreach (Player player in players)
        {
            player.Deal();
        }
        Player tia = players[0];
        Hand hand = tia.GetHand();
        Console.WriteLine("Tia's hand");
        hand.PrintHand();
        Console.WriteLine("Theo's hand");
        players[1].GetHand().PrintHand();
    }
}