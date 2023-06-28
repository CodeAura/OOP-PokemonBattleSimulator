using System;

namespace BattleSimulator 
{
    public class Pokemon {
        string name;
        string typeAttack;
        string weakness;

        public String? BattleCry;



        public Pokemon(String name, String typeAttack, String weakness) 
        {
            this.name = name;
            this.typeAttack = typeAttack;
            this.weakness = weakness;
        }



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
}


