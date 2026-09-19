using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1GOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя перонажа: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите базовую атаку персонажа: ");
            int attack = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите атаку оружия: ");
            int weaponAttack = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шанс критического удара: ");
            int changeCrit = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите критический урон в процентах: ");
            int CritDamage = int.Parse(Console.ReadLine());


            Character Char = new Character(name, attack, weaponAttack, changeCrit, CritDamage);
            Char.CalculateStats();
            Console.WriteLine($"Итоговая атака: {Char.TotalAttacks} \nСредний урон: {Char.SredUrons} \nШанс критического удара: {Char.ChangeCrit}\n" +
                $"Критический урон: {Char.CritUrons} \nИтоговый рейтинг сборки: {Char.ReitingSborkis}");


        }
    }
}
