using System;


namespace BattleSimulator;

public class Pokeball 
{
        public Pokemon pokemon;

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
        }

        public void closePokeball()
        {
            Console.WriteLine("The pokeball is closed.\n");
        }
}