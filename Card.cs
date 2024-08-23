// CABO

using System;

class Card 
{
    private int cardNumber;
    
    public Card(int cardNumber) 
    {
        this.cardNumber = cardNumber;
        // this is the instance of the class. class is a blueprint or instruction of how to create an object.
        // this represent a specific card.         
    }

    public int getNumber() 
    {
        return cardNumber;
    }

    public void PrintCard()
    {
        Console.WriteLine($"I am card {getNumber()}");
    }
}