// See https://aka.ms/new-console-template for more information

Card card = new Card(6);

Hand hand = new Hand(new List<Card>{card, card});
hand.PrintHand();

Console.WriteLine(Deque.GetSize());


// Human tia = new Human("Tia", 28);
// Human theo = new Human("Theodor", 24);

// tia.canBuyDrink("Beer");
// tia.canBuyDrink("Wine");

// Console.WriteLine(tia.name);

Player tia = new Player("Tia");
Player theo = new Player("Theo");

Game game = new Game(new List<Player>(){tia, theo});
game.Start();
