
namespace _01_Farm
{
    public class StartUp
    {
        static void Main()
        {
            var animal = new Animal();
            var dog = new Dog();
            var puppy = new Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            var cat = new Cat();

            cat.Eat();
            cat.Meow();

            dog.Eat();
            dog.Bark();
        }
    }
}
