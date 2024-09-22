using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sheep : Animal
{
    private static Random random = new Random();

    public Sheep(int quantity) : base(quantity, "Sheep") { }

    public override string MakeSound()
    {
        return "Baa!";
    }

    public override int ProduceMilk()
    {
        // Random milk between 0 and 5 liters for each sheep
        int milk = 0;
        for (int i = 0; i < Quantity; i++)
        {
            milk += random.Next(0, 6);
        }
        return milk;
    }

    public override int GiveBirth()
    {
        // Random birth count for each sheep
        int offspring = 0;
        for (int i = 0; i < Quantity; i++)
        {
            offspring += random.Next(1, 3); // Each sheep gives 1-2 offspring
        }
        return offspring;
    }
}
