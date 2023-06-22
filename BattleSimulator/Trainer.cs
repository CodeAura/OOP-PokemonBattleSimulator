using System;

namespace BattleSimulator 
{
    public class Trainer {
        public String name;
        

        public Trainer(String name) {
            this.name = name;
        }


        public override String ToString() 
        {
            return name;
        }

}
}


