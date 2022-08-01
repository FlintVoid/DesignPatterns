using System;

namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public class Creature : ICreature
    {
        public string Name { get; }
        private int _damage, _health;

        public Creature(string name, int damage, int health)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            _damage = damage;
            _health = health;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Damage: {_damage}, Health: {_health}";
        }

        public void MultiplyDamage(int multiply)
        {
            _damage *= multiply;
        }

        public void AddDamage(int value)
        {
            _damage += value;
        }

        public void MultiplyHealth(int multiply)
        {
            _health *= multiply;
        }

        public void AddHealth(int value)
        {
            _health += value;
        }
    }
}