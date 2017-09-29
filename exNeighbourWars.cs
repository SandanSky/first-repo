using System;

namespace exNeighbourWars
{
    class exNeighbourWars
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int cnt = 1;
            string winner = "";
            while (healthPesho > 0 && healthGosho > 0)
            {
                if (cnt % 2 == 0)
                {
                    healthPesho -= damageGosho;
                    if (healthPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    } else
                    {
                        winner = "Gosho"; break;
                    }
                }
                else
                {
                    healthGosho -= damagePesho;
                    if (healthGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    } else
                    {
                        winner = "Pesho"; break;
                     
                    }
                }
                
                if (cnt % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
                cnt++;
            }
            Console.WriteLine($"{winner} won in {cnt}th round.");
        }
    }
}
