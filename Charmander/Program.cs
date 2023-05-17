using System;

namespace Charmander
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon charmander = new Pokemon();
            charmander.setName("NeukerBeuker5000");
            charmander.setAttack("Fire");
            charmander.setWeakness("Water");

            while (true) {
                Console.WriteLine("Enter your Charmander Name: ");
                string? pokemonName = Console.ReadLine();


                Console.WriteLine("Pokemon Name: " + charmander.getName());
                Console.WriteLine("Pokemon Type: " + charmander);
                Console.WriteLine("Pokemon Type Attack: " + charmander.getTypeAttack());
                Console.WriteLine("Pokemon Weakness: " + charmander.getWeakness());
                
            }
        }
    }

    class Pokemon {
        public String? name;
        public String? typeAttack;
        public String? weakness;

        public void setName(String name) { 
            this.name = name;
        }
        public void setAttack(String typeAttack) {
            this.typeAttack = typeAttack;
        }
        public void setWeakness(String weakness) {
            this.weakness = weakness;
        }
        public String? getName() {
            return name;
        }

        public String? getTypeAttack() {
            return typeAttack;
        }

        public String? getWeakness() {
            return weakness;
        }
    }
}

