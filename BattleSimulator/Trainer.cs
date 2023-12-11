using System;

namespace BattleSimulator 
{
    internal class Trainer {

        string name;
        int number = 6;
        
        public List<Pokeball> belt;

        public Trainer(string name, List<Pokeball> belt) 
        {
            this.name = name;
            this.belt = belt;
        }

        public String? getName() 
        {
            return name;
        }

        public override String ToString() 
        {
            return name;
        }


        public void throwBall(int number) 
        {
            Console.WriteLine(name + " has thrown a pokeball.");

            belt[number].openPokeball();
        }

        public void closePokeball(int number = 1)
        {
            Console.WriteLine(name + " has returned a pokemon.\n");

            belt[number].closePokeball();
            Console.WriteLine(name + " has thrown " + number + " pokeballs.");
        }


        public void Pokedex() 
        {
            Console.WriteLine(name + " your pokedex: " + belt);
        }
        } 
}