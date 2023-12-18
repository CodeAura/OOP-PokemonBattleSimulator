namespace BattleSimulator
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void addTrainerToList(string Oname, string Cname) {

            // ! Trainers
            List<Trainer> trainers = new List<Trainer>();
            List<Pokeball> beltOpponent = new List<Pokeball>();
            List<Pokeball> beltChallanger = new List<Pokeball>();

            // ! Opponent 
            beltOpponent.Add(new Pokeball(new Charmander("Charmander", "Fire", "Water")));
            beltOpponent.Add(new Pokeball(new Bulbasar("Bulbasaur", "Grass", "Fire")));
            Trainer opponent = new Trainer(Oname, beltOpponent);
            trainers.Add(new Trainer(Oname, beltOpponent));

            // ! Challanger 
            beltChallanger.Add(new Pokeball(new Charmander("Charmander", "Fire", "Water")));
            beltChallanger.Add(new Pokeball(new Squirtle("Squirtle", "Water", "Grass")));
            Trainer challanger = new Trainer(Cname, beltChallanger);
            trainers.Add(new Trainer(Cname, beltChallanger));


            Console.WriteLine("The chosen Trainers: " + string.Join(", ", trainers.Select(trainer => trainer.GetName())));

            
            
            // Battle.ThrowBalls(Oname, Cname, beltChallanger, beltOpponent);

            for (int i = 1; i < 3; i++) {
                if(i == 1) {
                    Console.WriteLine(Oname + " Throw! (y/n)");
                    string? QOname = Console.ReadLine();
                    if (QOname == "y") {
                         for (int x = 0; x < beltOpponent.Count; x++) 
                        {
                            opponent.ThrowBall(x);
                            opponent.ClosePokeball(x);
                        }
                    }
                    if (QOname == "n") {
                        Console.WriteLine(Cname + " Won! | " + Oname + " You lose!");
                        continue;
                    }
                }
                else if(i == 2) {
                    Console.WriteLine(Cname + " Throw! (y/n)");
                    string? CQname = Console.ReadLine();
                    if(CQname == "y") {
                         for (int y = 0; y < beltChallanger.Count; y++) 
                         {
                            challanger.ThrowBall(y);
                            challanger.ClosePokeball(y);
                         }
                    }
                    if (CQname == "n") {
                        Console.WriteLine(Oname + " Won! | " + Cname + " You lose!");
                    }
                }
            }
            Battle.SimulateBattle(opponent, challanger);

        }
        // Trainer

        static void setTrainers(string Cname, string Oname) 
        {
             for (int i = 1; i < 3; i++) {
                    if(i == 1) {
                        Console.WriteLine("Enter your: " + i + "st Trainer name: ");
                        Oname = Console.ReadLine();
                    
                    }
                    else if(i == 2) {
                        Console.WriteLine("Enter your: " + i + "nd Trainer name");
                        Cname = Console.ReadLine();
                    }
                }
            addTrainerToList(Oname, Cname); 
        }
        static void Main(string[] args) {
            string? Cname = null;
            string? Oname = null;

            while (true) {
            Console.WriteLine(@"
            ██████╗  ██████╗ ██╗  ██╗███████╗███╗   ███╗ ██████╗ ███╗   ██╗
            ██╔══██╗██╔═══██╗██║ ██╔╝██╔════╝████╗ ████║██╔═══██╗████╗  ██║
            ██████╔╝██║   ██║█████╔╝ █████╗  ██╔████╔██║██║   ██║██╔██╗ ██║
            ██╔═══╝ ██║   ██║██╔═██╗ ██╔══╝  ██║╚██╔╝██║██║   ██║██║╚██╗██║
            ██║     ╚██████╔╝██║  ██╗███████╗██║ ╚═╝ ██║╚██████╔╝██║ ╚████║
            ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝
            ");

            setTrainers(Oname, Cname);


            // Question 

            Console.WriteLine("Do you want to restart the game? (y/n)");
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