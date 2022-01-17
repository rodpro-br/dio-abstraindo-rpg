using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_abstraindo_rpg.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public string HeroType { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Name}\r\nLevel: {this.Level}\r\nTipo: {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada";
        }

    }
}
