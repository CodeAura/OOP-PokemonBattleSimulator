using System;


namespace BattleSimulator;

class Pokeballs {
    public int Belt = 6;

    public void setPokeBalls(int pokeBalls) {
        this.Belt = pokeBalls;
    }

    public void usePokeballs() {
        for(int i = 0; i < this.Belt; i++) {
            Console.WriteLine("You have " + i + "pokeballs Left");
        }
    }
}