using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_RPG.Entities
{
    public abstract class Hero 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MP { get; set; }
        public int HP { get; set; }
        public int QtdAttackJenica { get; set; }
        public int QtdAttackTopapa { get; set; }
        public int QtdAttackAurus { get; set; }
        public int QtdAttackWedge { get; set; }
        public string HeroType { get; set; }
        public int CheersJenica { get; set; }
        public int CheersTopapa { get; set; }
        public int CheersAurus { get; set; }
        public int CheersWedge { get; set; }

        public Hero(string Name, int Level, int HP_Max, int MP_Max, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.MP = HP_Max;
            this.HP = HP_Max;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            switch (this.Name)
            {
                case ("Jenica"):
                    return $@"Nome: {this.Name } - Hero Type: {this.HeroType} - Level: {this.Level} - MP {QtdAttackJenica}/{this.MP} - HP {CheersJenica}/{this.HP}"; 
                    break;
                case ("Topapa"):
                    return $@"Nome: {this.Name } - Hero Type: {this.HeroType}  - Level: {this.Level} - MP {QtdAttackTopapa}/{this.MP} - HP {CheersTopapa}/{this.HP}";
                    break;
                case ("Aurus"):
                    return $@"Nome: {this.Name } - Hero Type: {this.HeroType}  - Level: {this.Level} - MP {QtdAttackAurus}/{this.MP} - HP {CheersAurus}/{this.HP}"; 
                    break;
                case ("Wedge"):
                    return $@"Nome: {this.Name } - Hero Type: {this.HeroType}  - Level: {this.Level} - MP {QtdAttackWedge}/{this.MP} - HP {CheersWedge}/{this.HP}";
                    break;
            }
            return String.Empty;           
        }

        public abstract string Attack();
        public abstract int Attack(Hero hero);
        public abstract int HealthLoss();
    }
}
