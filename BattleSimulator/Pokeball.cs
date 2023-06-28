using System;


namespace BattleSimulator;

internal class Pokeball 
{
        Pokemon charmander;

        public Pokeball(Pokemon charmander)
        {
            this.charmander = charmander;
        }

        public void openPokeball()
        {
            Console.WriteLine("The pokeball is opened\n");
            Console.WriteLine("The Pokeball contains a " + charmander.getName());
            charmander.setBattleCry("Rawhh");
            charmander.useBattleCry();

            Console.WriteLine("\nPlease enter your new " + charmander.getName() + " name");
            string? pokemonName = Console.ReadLine();
            charmander.setName(pokemonName);
            charmander.useBattleCry();

        }

        public void closePokeball()
        {
            Console.WriteLine("The pokeball is closed.\n");
        }
}