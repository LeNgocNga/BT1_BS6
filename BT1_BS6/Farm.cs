using System;
using System.Collections.Generic;

public class Farm
{
    public Cow Cows { get; set; }
    public Sheep Sheep { get; set; }
    public Goat Goats { get; set; }

    public Farm(int cows, int sheep, int goats)
    {
        Cows = new Cow(cows);
        Sheep = new Sheep(sheep);
        Goats = new Goat(goats);
    }

    public string GetSounds()
    {
        return $"{Cows.MakeSound()} {Sheep.MakeSound()} {Goats.MakeSound()}";
    }

    public int TotalMilk()
    {
        return Cows.ProduceMilk() + Sheep.ProduceMilk() + Goats.ProduceMilk();
    }

    public int TotalOffspring()
    {
        return Cows.GiveBirth() + Sheep.GiveBirth() + Goats.GiveBirth();
    }
}
