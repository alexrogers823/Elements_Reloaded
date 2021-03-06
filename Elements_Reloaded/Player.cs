﻿using System;
namespace Elements_Reloaded
{
    public abstract class Player
    {
        public string Name { get; protected set; }
        public string ElementType { get; protected set; }
        public int LifePoints { get; protected set; }
        protected bool HasWeapon { get; set; } = false;
        protected string WeaponAttack;
        protected virtual int WeaponBaseDamage { get; set; }

        public Player(string name, string elementType)
        {
            Name = name;
            ElementType = elementType;
        }

        public void Attack(string attack)
        {
            Console.WriteLine($"{this.Name} attacks with {attack}!");
        }

        public void Attack(string attack, int attackPoints)
        {
            Console.WriteLine($"{this.Name} attacks with {attack}, causing {attackPoints} damage!");
        }

        public void TakeDamage(int damage)
        {
            LifePoints -= damage;
        }

        public int GetLP()
        {
            return LifePoints;
        }

        public virtual void ShowGameStats()
        {
            Console.WriteLine(
                $"{this.Name}: {this.ElementType} Type," +
                $" LP: {this.LifePoints}");
        }
    }
}
