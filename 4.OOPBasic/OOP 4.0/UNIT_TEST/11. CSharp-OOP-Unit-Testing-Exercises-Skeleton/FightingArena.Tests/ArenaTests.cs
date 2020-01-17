using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena testArena;
        [SetUp]
        public void Setup()
        {
            testArena = new Arena();

          
        }

        [Test]
        public void ValidConstructor()
        {
            var test =new Arena();

            Assert.That(test.Warriors.GetType().Name.ToString(), Is.EqualTo("List`1"));
        }

        [Test]
        public void EnrollTest()
        {
            var number=0;
            
                for ( number = 1; number < 10; number++)
                {
                    var testWarrior = new Warrior(number.ToString(), number, number);
                testArena.Enroll(testWarrior);
                }

            Assert.That(testArena.Count, Is.EqualTo(number-1));
          
        }

        [Test]
        public void EnrollTwiceTest()
        {
           
            for (var number = 1; number <= 10; number++)
            {
                var testWarrior = new Warrior(number.ToString(), number, number);
                testArena.Enroll(testWarrior);
            }

            for (var number = 1; number <= 10; number++)
            {
                var testWarrior = new Warrior(number.ToString(), number, number);
                Assert.That(()=>testArena.Enroll(testWarrior),
                    Throws.InvalidOperationException.With.Message
                    .EqualTo("Warrior is already enrolled for the fights!"));
            }

        }

        [Test]
        public void TestFightMissingAttacker()
        {
            for (var number = 1; number <= 10; number++)
            {
                var testWarrior = new Warrior(number.ToString(), number, number);
                testArena.Enroll(testWarrior);
            }

            var randomizer = new Random();

            var randomDefenderName = randomizer.Next(1, 10).ToString();
            var randomAttatckerName = randomizer.Next(11, 20).ToString();

           Assert.That(()=> testArena.Fight(randomAttatckerName, randomDefenderName),Throws.InvalidOperationException.With.Message.EqualTo($"There is no fighter with name {randomAttatckerName} enrolled for the fights!")); 
        }

        [Test]
        public void TestFightMissingDefender()
        {
            for (var number = 1; number <= 10; number++)
            {
                var testWarrior = new Warrior(number.ToString(), number, number);
                testArena.Enroll(testWarrior);
            }

            var randomizer = new Random();

            var randomDefenderName = randomizer.Next(11, 20).ToString();
            var randomAttatckerName = randomizer.Next(1, 10).ToString();

            Assert.That(() => testArena.Fight(randomAttatckerName, randomDefenderName), Throws.InvalidOperationException.With.Message.EqualTo($"There is no fighter with name {randomDefenderName} enrolled for the fights!"));
        }
    }
}
