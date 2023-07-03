using System;

namespace BattleSimulator 
{
    public class Pokemon {
        public string name;
        public string typeAttack;
        public string weakness;

        public String? BattleCry;


        // Parent Class

        public Pokemon(String name, String typeAttack, String weakness) 
        {
            this.name = name;   
            this.typeAttack = typeAttack;
            this.weakness = weakness;
        }

        // Getters en Setters

        public void setName(String name) { 
            this.name = name;
        }

        public void setTypeAttack(String typeAttack) {
            this.typeAttack = typeAttack;
        }


        public void setBattleCry(String BattleCry) {
            this.BattleCry = BattleCry;
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
        public String? getBattleCry() {
            return BattleCry;
        }


        public void useBattleCry() {
            Console.WriteLine(getName() + " uses their battleCry: " + getBattleCry());
        }
    }

    // Child Classes
    public class Charmander : Pokemon {
        public Charmander(string name, string typeAttack, string weakness) : base(name, typeAttack, weakness) 
        { 
            this.name = name;
            this.typeAttack = typeAttack;
            this.weakness = weakness;
        }
    }


    public class Squirtle : Pokemon {
        public Squirtle(string name, string typeAttack, string weakness) : base(name, typeAttack, weakness) 
        { 
            this.name = name;
            this.typeAttack = typeAttack;
            this.weakness = weakness;
        }
    }

    public class Bulbasar : Pokemon {
        public Bulbasar(string name, string typeAttack, string weakness) : base(name, typeAttack, weakness) 
        {
            this.name = name;
            this.typeAttack = typeAttack;
            this.weakness = weakness;
        }
    }
}


