namespace BattleSimulator 
{

class Battle
{
    Trainer challanger;
    Trainer opponent;

    Pokemon pokemon;
    Pokeball pokeball;
   
    public Battle(Trainer opponent, Trainer challanger) {
        this.opponent = opponent;
        this.challanger = challanger;
    }
    // public static void ThrowBalls(string Oname, string Cname, string beltOpponent, string beltChallanger) {
    //     for (int i = 1; i < 3; i++) {
    //             if(i == 1) {
    //                 Console.WriteLine(Oname + " Throw! (y/n)");
    //                 string? QOname = Console.ReadLine();
    //                 if (QOname == "y") {
    //                     for (int x = 0; x < beltOpponent.Count; x++) 
    //                     {
    //                         opponent.throwBall(x);
    //                         opponent.closePokeball(x);
    //                     }    
    //                 }
    //                 if (QOname == "n") {
    //                     Console.WriteLine(Cname + " Won! | " + Oname + " You lose!");
    //                     continue;
    //                 }
    //             }
    //             else if(i == 2) {
    //                 Console.WriteLine(Cname + " Throw! (y/n)");
    //                 string? CQname = Console.ReadLine();
    //                 if(CQname == "y") {
    //                      for (int y = 0; y < beltChallanger.Count; y++) 
    //                      {
    //                         challanger.throwBall(y);
    //                         challanger.closePokeball(y);
    //                      }
    //                 }
    //                 if (CQname == "n") {
    //                     Console.WriteLine(Oname + " Won! | " + Cname + " You lose!");
    //                 }
    //             }
    //         }

    public static string previous_winner;

    public static void SimulateBattle(Trainer opponent, Trainer challanger, string beltOpponent, string beltChallanger)
    {
        int? scoreboard = 0;
        string? winner = "";

        bool defeated_pokemon1 = false;
        bool defeated_pokemon2 = false;
        
        if (opponent.belt[beltOpponent].pokemon?.getWeakness() == challanger.belt[beltChallanger].pokemon?.getTypeAttack())
        {
            winner = challanger.getName();
            previous_winner = challanger.getName();
            scoreboard += 1;
            defeated_pokemon1 = true;
        }
        else if (opponent.belt[beltOpponent].pokemon?.getTypeAttack() == challanger.belt[beltChallanger].pokemon?.getWeakness())
        {
            winner = opponent.getName();
            previous_winner = opponent.getName();
            scoreboard += 1;
            defeated_pokemon2 = true;
        }
        else
        {
            winner = "nobody";
        }

        Console.Write("");
        opponent.belt[beltOpponent].pokemon?.getBattleCry();
        Console.WriteLine("");

        challanger.belt[beltChallanger].pokemon?.getBattleCry();
        Console.WriteLine("");

        Console.WriteLine(winner + " wins");
        Console.WriteLine("");

        if (winner == "nobody")
        {
            if (previous_winner == null)
            {
                Console.WriteLine(opponent.getName() + " calls back " + opponent.belt[beltOpponent].pokemon?.getName());
                opponent.belt[beltOpponent].closePokeball();

                Console.WriteLine(challanger.getName() + " calls back " + challanger.belt[beltChallanger].pokemon?.name);
                challanger.belt[beltChallanger].closePokeball();
                beltOpponent += 1;
            } else if(previous_winner == opponent.getName())
            {
                Console.WriteLine(challanger.getName() + " calls back " + challanger.belt[beltChallanger].pokemon?.name);
                challanger.belt[beltChallanger].closePokeball();
                beltChallanger += 1;
            }
            else if (previous_winner == challanger.getName())
            {
                Console.WriteLine(opponent.getName() + " calls back " + opponent.belt[beltOpponent].pokemon?.name);
                opponent.belt[beltOpponent].closePokeball();
                beltOpponent += 1;
            }
            
        }
        else if (defeated_pokemon1)
        {
            Console.WriteLine(opponent.getName() + " calls back " + opponent.belt[beltOpponent].pokemon?.name);
            opponent.belt[beltOpponent].closePokeball();
            defeated_pokemon1 = false;
            beltOpponent += 1;
            
        }
        else if (defeated_pokemon2)
        {
            Console.WriteLine(challanger.getName() + " calls back " + challanger.belt[beltChallanger].pokemon?.name);
            challanger.belt[beltChallanger].closePokeball();
            defeated_pokemon2 = false;
            beltChallanger += 1;
        }

    }

}

}