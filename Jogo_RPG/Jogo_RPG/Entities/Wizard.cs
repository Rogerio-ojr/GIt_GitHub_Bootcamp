using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, int HP_Max, int MP_Max, string HeroType) : base(Name, Level, HP_Max, MP_Max, HeroType)
        {

        }

        public override string Attack()
        {
            HealthLoss();
            return $@"{this.Name} Lançou Magia";
        }

        public override int Attack(Hero hero)
        {
            HealthLoss();
            switch (this.Name)
            {
                case ("Jenica"):
                    return QtdAttackJenica++;
                    break;
                case ("Topapa"):
                    return QtdAttackTopapa++;
                    break;
                case ("Aurus"):
                    return QtdAttackAurus++;
                    break;
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
                    return CheersJenica+=10;
                    break;
                case ("Topapa"):
                    return CheersTopapa += 10;
                    break;
            }
            return 0;
        }
    }
}
