using System;


namespace BattleSimulator;

internal class Pokeball 
{
        Pokemon pokemon;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }

        public void openPokeball()
        {
            Console.WriteLine("The pokeball is opened\n");
            Console.WriteLine("The Pokeball contains a " + pokemon.getName());

            Console.WriteLine("Attack Type: " + pokemon.getTypeAttack());
            Console.WriteLine("Weakness: " + pokemon.getWeakness());
            pokemon.setBattleCry(pokemon.getName() + "!");
            pokemon.useBattleCry();

            Console.WriteLine("\nPlease enter your new " + pokemon.getName() + " name");
            string? pokemonName = Console.ReadLine();
            pokemon.setName(pokemonName);
            pokemon.useBattleCry();

        }

        public void closePokeball()
        {
            Console.WriteLine("The pokeball is closed.\n");
        }
}