
namespace BattleSimulator
{
    using System.Threading;

    class Battle
    {
        public Trainer challenger;
        public Trainer opponent;

        public Pokemon pokemon;
        public Pokeball pokeball;

        public Battle(Trainer opponent, Trainer challenger, Pokemon pokemon, Pokeball pokeball)
        {
            this.opponent = opponent;
            this.challenger = challenger;
            this.pokemon = pokemon;
            this.pokeball = pokeball;
        }

        public static void SimulateBattle(Trainer challenger, Trainer opponent)
        {
            Console.WriteLine($"Battle Start: {challenger.Name} vs {opponent.Name}");

            Pokemon challengerPokemon = challenger.belt[1].pokemon;
            Pokemon opponentPokemon = opponent.belt[1].pokemon;


            Thread.Sleep(1000);
            Console.WriteLine($"{challenger.Name}: {challenger.belt[1].pokemon.name} I choose you!");
            Thread.Sleep(500);
            Console.WriteLine($"{opponent.Name}: {opponent.belt[1].pokemon.name} I choose you!");
            Thread.Sleep(1000);
            
            if (challengerPokemon.typeAttack == opponentPokemon.weakness)
            {
            Console.WriteLine($"{challengerPokemon.name} Uses {challengerPokemon.typeAttack}");
            Console.WriteLine($"{challenger.Name}'s {challengerPokemon.name} is super effective!");
            Console.WriteLine($"{challenger.Name} Wins!");
            }
            else if (opponentPokemon.typeAttack == challengerPokemon.weakness)
            {
            Console.WriteLine($"{opponentPokemon.name} Uses {opponentPokemon.typeAttack}");
            Console.WriteLine($"{opponent.Name}'s {opponentPokemon.name} is super effective!");
            Console.WriteLine($"{opponent.Name} Wins!");
            }
            else
            {
            Console.WriteLine("It's a draw!");
            }
            Console.WriteLine("Battle End!");
        }
    }
}
