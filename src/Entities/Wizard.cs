using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_abstraindo_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {

        }

        public override string Attack() 
        {
            return $"{this.Name} lançou sua magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} lançou sua magia super efetiva com bônus de ataque {bonus}";
            }

            return $"{this.Name} lançou sua magia com bônus de ataque {bonus}";

        }
    }
}
