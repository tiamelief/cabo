using System.Globalization;

class HighestMountain
 {
    public static string name = "Mount Everest";
    public static int elevation = 8848;
}

class Atmosphere
{
    private string name;

    public Atmosphere(string name)
    {
        this.name = name;
    }
}

class Planet {
    private string name;

    public Planet(string name) {
        this.name = name;
    }
}

class Human {
    public string name {get; private set; }
    public int age {get; private set; }

    private static Planet earth = new Planet("Earth");
    private static Atmosphere oxygen = new Atmosphere("Oxygen");

    public Human(string name, int age)
    {
        this.name = name.ToLowerInvariant();
        this.age = age;
    }

    public bool isEligibleForSASYouthTicket() {
        return age <= 25;
    }

    public void canBuyDrink(string drink) 
    {
        if (drink.Equals("Beer")) 
        {
            if (age >= 16) 
            {
                Console.WriteLine($"You can buy {drink}");
            } 
            else 
            {
                Console.WriteLine($"Banned for you");
            }
        }
        if (drink.Equals("Wine")) 
        {
            if (age >= 18) 
            {
                Console.WriteLine($"You can drink {drink}");
            } 
            else 
            {
                Console.WriteLine($"Banned for you");
            }
        }
    }

    public static Planet GetEarth() 
    {
        return earth;
    }

    public static Atmosphere GetOxygen()
    {
        return oxygen;
    }
    // the reason with 'static' is because all 'Human''s Instance(fx. name, age) share the same 'Earth' (attribute)

}
