

namespace BattleSimulator
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void addTrainerToList(string Oname, string Cname) {
            List<Trainer> trainers = new List<Trainer>();
            Trainer opponent = new Trainer(Oname);
            Trainer challanger = new Trainer(Cname);
            trainers.Add(new Trainer(Oname));
            trainers.Add(new Trainer(Cname));

            Console.WriteLine(String.Join(", ", trainers));
        }
        // Trainer
        static void Main(string[] args) {
            string? Cname = null;
            string? Oname = null;

            while (true) {
                 for (int i = 1; i < 3; i++) {
                    if(i == 1) {
                        Console.WriteLine("Enter your: " + i + "st Trainer name: ");
                        Oname = Console.ReadLine();
                        addTrainerToList(Oname, Cname);
                    }
                    else if(i == 2) {
                        Console.WriteLine("Enter your: " + i + "nd Trainer name");
                        Cname = Console.ReadLine();
                        addTrainerToList(Oname, Cname); 
                    }
                 }
                // Pokemon
                Console.WriteLine("Choose your Charmander name?");
                Pokemon charmander = new Pokemon();
                string? Pokemonname = Console.ReadLine();
                charmander.setName(Pokemonname);
                charmander.setAttack("Fire");
                charmander.setWeakness("Water");
                charmander.setBattleCry("Raaaawh");
                Console.WriteLine("Pokemon Name: " + charmander.getName());
                Console.WriteLine("Pokemon Weakness: " + charmander.getWeakness());
                Console.WriteLine("Pokemon Type Attack: " + charmander.getTypeAttack());

                for (int i = 0; i < 10; i++) {
                    charmander.useBattleCry();
                }


            // Question

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