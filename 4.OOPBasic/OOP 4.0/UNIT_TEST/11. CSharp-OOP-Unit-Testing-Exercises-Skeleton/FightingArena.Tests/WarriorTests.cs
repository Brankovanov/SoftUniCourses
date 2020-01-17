using NUnit.Framework;
using FightingArena;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior testWarriorOne;
        private Warrior testWarriorTwo;
        [SetUp]
        public void Setup()
        {
            this.testWarriorOne = new Warrior("One", 10, 100);
            this.testWarriorTwo = new Warrior("Two", 20, 200);
        }

        [Test]
        public void NullName()
        {
            Assert.That(()=> new Warrior(null, 10, 100)
            ,Throws.ArgumentException.With.Message
            .EqualTo("Name should not be empty or whitespace!"));
        }

        [Test]
        public void EmptyName()
        {
            Assert.That(() => new Warrior(string.Empty, 10, 100)
            , Throws.ArgumentException.With.Message
            .EqualTo("Name should not be empty or whitespace!"));
        }

        [Test]
        public void WhtiteSpaceName()
        {
            Assert.That(() => new Warrior(" ", 10, 100)
            , Throws.ArgumentException.With.Message
            .EqualTo("Name should not be empty or whitespace!"));
        }

        [Test]
        public void ZeroDamage()
        {
            Assert.That(() => new Warrior("stamat", 0, 100)
           , Throws.ArgumentException.With.Message
           .EqualTo("Damage value should be positive!"));
        }

        [Test]
        public void NegativeDamage()
        {
            Assert.That(() => new Warrior("stamat", -10, 100)
           , Throws.ArgumentException.With.Message
           .EqualTo("Damage value should be positive!"));
        }

        [Test]
        public void NegativeHealth()
        {
            Assert.That(() => new Warrior("stamat", 10, -100)
           , Throws.ArgumentException.With.Message
           .EqualTo("HP should not be negative!"));
        }

        [Test]
        public void MinAttackHp()
        {
            var attkWarrior = new Warrior("Attk", 12, 12);
            var defWarrior = new Warrior("Def", 12, 33);

            Assert.That(() => attkWarrior.Attack(defWarrior)
            , Throws.InvalidOperationException.With.Message
            .EqualTo("Your HP is too low in order to attack other warriors!"));
        }


        [Test]
        public void MinDefHp()
        {
            var defWarrior = new Warrior("Attk", 12, 12);
            var attkWarrior = new Warrior("Def", 12, 33);

            Assert.That(() => attkWarrior.Attack(defWarrior)
            , Throws.InvalidOperationException.With.Message
            .EqualTo($"Enemy HP must be greater than 30 in order to attack him!"));
        }

        [Test]
        public void AttackStronger()
        {
            var attkWarrior = new Warrior("Attk", 12, 33);
            var defWarrior = new Warrior("Def", 34, 33);

            Assert.That(() => attkWarrior.Attack(defWarrior)
            , Throws.InvalidOperationException.With.Message
            .EqualTo($"You are trying to attack too strong enemy"));
        }

        [Test]
        public void SuccssesfullLethalAttack()
        {
            var attkWarrior = new Warrior("Attk", 34, 33);
            var defWarrior = new Warrior("Def", 13, 33);

            attkWarrior.Attack(defWarrior);

            Assert.That(defWarrior.HP, Is.EqualTo(0));
        }

        [Test]
        public void SuccssesfullAttack()
        {
            var attkWarrior = new Warrior("Attk", 15, 33);
            var defWarrior = new Warrior("Def", 13, 33);

            attkWarrior.Attack(defWarrior);

            Assert.That(defWarrior.HP, Is.EqualTo(33-attkWarrior.Damage));
        }


    }
}