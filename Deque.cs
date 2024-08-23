class Deque
{
    static private Stack<Card> cards = new Stack<Card>();
    static public readonly Dictionary<int, int> CARD_COUNT = new Dictionary<int, int>(){
        {0, 2},
        {1, 4},
        {2, 4},
        {3, 4},
        {4, 4},
        {5, 4},
        {6, 4},
        {7, 4},
        {8, 4},
        {9, 4},
        {10, 4},
        {11, 4},
        {12, 4},
        {13, 2},
    };

    private static Random random = new Random();


    static Deque() {
        foreach (KeyValuePair<int, int> cardCount in CARD_COUNT)
        {
            int number = cardCount.Key;
            int count = cardCount.Value;
            for (int i = 0; i < count; i++)
            {
                cards.Push(new Card(number));
            }
            
        }
    }

    public static int GetSize() {
        return cards.Count;
    }
    
    public static void Shuffle() {
        cards = new Stack<Card>(cards.OrderBy(_ => random.Next()));
    }

    public static Card Take() {
        return cards.Pop();
    }
}