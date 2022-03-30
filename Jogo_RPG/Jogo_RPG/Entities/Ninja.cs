using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_RPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HP_Max, int MP_Max, string HeroType) : base(Name, Level, HP_Max, MP_Max, HeroType)
        {
            
        }

        public override string Attack()
        {
            HealthLoss();
            return $@"{this.Name} atacou com a sua espada";
        }

        public override int Attack(Hero hero)
        {
            HealthLoss();
            switch (this.Name)
            {
                case ("Wedge"):
                    return QtdAttackWedge++;
                    break;
            }
            return 0;
        }

        public override int HealthLoss()
        {
            switch (this.Name)
            {
                case ("Jenica"):
                    return CheersWedge += 3;
                    break;
            }
            return 0;
        }
    }
}
