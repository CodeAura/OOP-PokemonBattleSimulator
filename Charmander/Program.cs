using System;

namespace Charmander
{
    internal class Program
    {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Choose your Charmander name?");
                Pokemon charmander = new Pokemon();
                string? Pokemonname = Console.ReadLine();
                charmander.setName(Pokemonname);
                charmander.setAttack("Fire");
                charmander.setWeakness("Water");
                charmander.setBattleCry("Charmander!");
                Console.WriteLine("Pokemon Name: " + charmander.getName());
                Console.WriteLine("Pokemon Weakness: " + charmander.getWeakness());
                Console.WriteLine("Pokemon Type Attack: " + charmander.getTypeAttack());

                for (int i = 0; i < 10; i++) {
                    Console.WriteLine("BattleCry: " + charmander.getBattleCry());
                }
            Console.WriteLine("Do you want a new pokemon? (y/n)");
            string? Question = Console.ReadLine();

            if (Question == "y") {
                continue;
            } else if (Question == "n") {
                break;
            } else {
                Console.WriteLine("Please enter a valid question awnser");
            }
            }
        }
    }
}