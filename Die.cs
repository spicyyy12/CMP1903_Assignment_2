using System;

namespace OOP_Assignment_2;
public class Die
{
    // Holds the current value of the die
    public int DieValue { get; private set; }

    public Die()
    {
        // Default dice valur before every roll
        DieValue = 1;
    }

    public int Roll()
    {
        // dice number generator
        Random random = new Random();
        DieValue = random.Next(1, 7); 
        return DieValue;
    }
}