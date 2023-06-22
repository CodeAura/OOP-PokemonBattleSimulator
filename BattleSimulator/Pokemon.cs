using System;

namespace BattleSimulator 
{
    public class Pokemon {
        public String? name;
        public String? typeAttack;
        public String? weakness;

        public String? BattleCry;

        public void setName(String name) { 
            this.name = name;
        }
        public void setAttack(String typeAttack) {
            this.typeAttack = typeAttack;
        }
        public void setWeakness(String weakness) {
            this.weakness = weakness;
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


