namespace Lab_01_Animals
{
    public class StartUp
    {
        public static void Main()
        {
            var puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            var dog = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
