using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            int adventureDay1 = int.Parse(Console.ReadLine());
            int numParticipants = int.Parse(Console.ReadLine());
            double groupEnerg1 = double.Parse(Console.ReadLine());
            double dailyWaterPerPerson = double.Parse(Console.ReadLine());
            double dailyFoodPerPerson = double.Parse(Console.ReadLine());
            double energy = groupEnerg1;
            double water = numParticipants * dailyWaterPerPerson;
            double food = numParticipants * dailyFoodPerPerson;

            for (int day = 1; day <= adventureDay1; day++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                energy -= energyLoss;

                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {food:F2} food and {water:F2} water.");
                    return;
                }

                if (day % 2 == 0)
                {
                    water -= (water * 0.3);
                    energy *= 1.05;
                }

                if (day % 3 == 0)
                {
                    food -= (food / numParticipants);
                    energy *= 1.1;
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }





        }
    }
}
