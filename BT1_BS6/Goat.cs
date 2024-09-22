using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Goat : Animal
{
    private static Random random = new Random();

    public Goat(int quantity) : base(quantity, "Goat") { }

    public override string MakeSound()
    {
        return "Bleat!";
    }

    public override int ProduceMilk()
    {
        // Random milk between 0 and 10 liters for each goat
        int milk = 0;
        for (int i = 0; i < Quantity; i++)
        {
            milk += random.Next(0, 11);
        }
        return milk;
    }

    public override int GiveBirth()
    {
        // Random birth count for each goat
        int offspring = 0;
        for (int i = 0; i < Quantity; i++)
        {
            offspring += random.Next(1, 3); // Each goat gives 1-2 offspring
        }
        return offspring;
    }
}
