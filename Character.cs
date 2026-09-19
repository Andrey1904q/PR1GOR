using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1GOR
{
    public class Character
    {
        public string Name { get; set; }
        public int BaseAtack { get; set; }
        public int Weapon { get; set; }
        public int ChangeCrit { get; set; } // шанс крит удара

        public int CritDamage { get; set; } //урон в процентах
        public int TotalAttacks { get; set; }
        public int CritUrons { get; set; }
        public int SredUrons { get; set; }
        public string ReitingSborkis { get; set; }

        public Character(string name, int baseatack, int weaponatack, int critchange, int crit)
        {
            Name = name;
            BaseAtack = baseatack;
            Weapon = weaponatack;
            ChangeCrit = critchange;
            CritDamage = crit;
        }

        public void CalculateStats()
        {
            TotalAttacks = TotalAttack();
            CritUrons = CritUron();
            SredUrons = SredUron();
            ReitingSborkis = ReitingSborki();
        }

        public int TotalAttack()
        {
            return BaseAtack + Weapon;
        }
        public int CritUron()
        {
            int itog = TotalAttack();
            return itog * (1 + (CritDamage / 100));
        }
        public int SredUron()
        {
            int itog = TotalAttack();
            return itog * (1 + (ChangeCrit / 100) * (CritUrons / 100));
        }

        public string ReitingSborki()
        {
            int sredUron = SredUron();

            if (sredUron < 1500)
                return "Слабая";
            else if (sredUron >= 1500 && sredUron <= 2499)
                return "Нормальная";
            else if (sredUron >= 2500 && sredUron <= 3499)
                return "Хорошая";
            else if (sredUron >= 3500)
                return "Отличная";
            else
                return "Неизвестно";

        }
    }
}
