using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database.Database testDB;

        [SetUp]
        public void Setup()
        {
            testDB = new Database.Database();
        }

        [Test]
        public void Limit()
        {
            Assert.That(this.testDB.Count, Is.LessThan(16));
        }

        [Test]
        public void BeyoundLimit()
        {

            Assert.That(() => new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 12, 12, 3, 213, 4, 6).Count != 16,
                Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void Adding()
        {
            var number = 12312;
            var count = testDB.Count;
            testDB.Add(number);
            Assert.That(testDB.Count > count);
        }

        [Test]
        public void AddingnitLi()
        {
            
            var count = testDB.Count;
            for (var cycle = 0; cycle < 16; cycle++)
            {

                testDB.Add(cycle);
                
            }

            Assert.That(() => testDB.Add(0),
                    Throws.InvalidOperationException.With
                    .Message.EqualTo("Array's capacity must be exactly 16 integers!")); ;
        }

        [Test]
        public void RemoveTest()
        {
           

            for (var cycle = 1; cycle < 16; cycle++)
            {

                testDB.Add(cycle);

            }
            var testCount = testDB.Count;
            testDB.Remove();

            Assert.That(testDB.Count<testCount );
        }

        [Test]
        public void RemoveTestFromEmpty()
        {
            Assert.That(() => testDB.Remove(),
                     Throws.InvalidOperationException.With
                     .Message.EqualTo("The collection is empty!")); ;           
        }

       [Test]
       public void TestFetch()
        {
            Assert.That(testDB.Fetch().GetType().ToString(), Is.EqualTo("System.Int32[]"));
        }
    }
}
