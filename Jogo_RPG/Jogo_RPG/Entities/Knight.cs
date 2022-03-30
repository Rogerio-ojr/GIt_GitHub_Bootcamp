using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_RPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int HP_Max, int MP_Max, string HeroType) : base(Name, Level, HP_Max, MP_Max, HeroType)
        {
            
        }

        public override string Attack()
        {
            HealthLoss();
            return $@"{this.Name} atacou com o seu cavalo";
        }

        public override int Attack(Hero hero)
        {
            HealthLoss();
            switch (this.Name)
            {
                case ("Aurus"):
                    return QtdAttackAurus++;
                    break;
            }
            return 0;
        }

        public override int HealthLoss()
        {
            switch (this.Name)
            {
                case ("Jenica"):
                    return CheersAurus += 3;
                    break;
            }
            return 0;
        }
    }
}
