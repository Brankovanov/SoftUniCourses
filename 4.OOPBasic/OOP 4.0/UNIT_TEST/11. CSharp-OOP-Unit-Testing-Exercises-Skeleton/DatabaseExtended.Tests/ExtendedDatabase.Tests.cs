using DatabaseExtended;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase testExtDB;

        [SetUp]
        public void Setup()
        {
            var testPersons = new Person[15];

            for (var index = 0; index < 15; index++)
            {
                var newTestPerson = new Person(index, $"Ivan+{index}");
                testPersons[index] = newTestPerson;
            }

            testExtDB = new ExtendedDatabase(testPersons);
        }

        [Test]
        public void UniqueUserTest()
        {
            var newRandom = new Random();

            for (var index = 0; index <= 15; index++)
            {
                var randomizedIndex = newRandom.Next(0, 14);
                Assert.That(() => testExtDB.Add(testExtDB.FindById(randomizedIndex)),
                    Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this username!"));
            }
        }

        [Test]
        public void Remove()
        {
            var testCount = testExtDB.Count;
            testExtDB.Remove();
            Assert.That(testExtDB.Count < testCount);
        }

        [Test]
        public void RemoveFromEmpty()
        {
            var newtestDb = new ExtendedDatabase();
            Assert.That(() => newtestDb.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUserName()
        {
            var randomIndex = new Random();

            for (var index = 0; index <= 15; index++)
            {
                var randomized = randomIndex.Next(0, 14);
                Assert.That(testExtDB.FindByUsername(testExtDB.FindById(randomized).UserName)
                    .Equals(testExtDB.FindById(randomized)));
            }
        }

        [Test]
        public void MissingName()
        {   
                Assert.That(() => testExtDB.FindByUsername("MissingName"),
                    Throws.InvalidOperationException.With.Message
                    .EqualTo("No user is present by this username!"));     
        }

        [Test]
        public void NullName()
        {
                Assert.That(() => testExtDB.FindByUsername(null),
                    Throws.ArgumentNullException);   
        }

        [Test]
        public void EmptyName()
        {
            var testName = string.Empty;

            Assert.That(() => testExtDB.FindByUsername(testName),
                Throws.ArgumentNullException);
        }

        [Test]
        public void CaseSensitiveLow()
        {
            var randomIndex = new Random();

            for (var index = 0; index <= 15; index++)
            {
                var randomized = randomIndex.Next(0, 14);
                Assert.That(()=> testExtDB.FindByUsername(testExtDB.FindById(randomized).UserName.ToLower()),
                    Throws.InvalidOperationException.With.Message
                    .EqualTo("No user is present by this username!"));
            }
        }
        
         [Test]
        public void CaseSensitiveUp()
        {
            var randomIndex = new Random();

            for (var index = 0; index <= 15; index++)
            {
                var randomized = randomIndex.Next(0, 14);
                Assert.That(() => testExtDB.FindByUsername(testExtDB.FindById(randomized).UserName.ToUpper()),
                    Throws.InvalidOperationException.With.Message
                    .EqualTo("No user is present by this username!"));
            }
        }

        [Test]
        public void FindByUserId()
        {
            var randomIndex = new Random();

            for (var index = 0; index <= 15; index++)
            {
                var randomized = randomIndex.Next(0, 14);
                Assert.That(testExtDB.FindById((testExtDB.FindById(randomized).Id))
                    .Equals(testExtDB.FindById(randomized)));
            }
        }

        [Test]
        public void MissingId()
        {
            Assert.That(() => testExtDB.FindById(6775765765),
                Throws.InvalidOperationException.With.Message
                .EqualTo("No user is present by this ID!"));
        }


        [Test]
        public void NegativeId()
        {
            Assert.That(() => testExtDB.FindById(-6775765765),
                Throws.Exception);
        }
    }
}