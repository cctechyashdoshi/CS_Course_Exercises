namespace Advanced_Method_Overriding
{
    internal class Program
    {
        public class Animal() 
        {
            public virtual void MakeSound() 
            {
                Console.Write("Animal makes a sound");
            } 
        }

        public class  Dog(): Animal
        {
            public override void MakeSound() 
            {
                Console.Write("Dog barks");
            }
        }

        public class Cat() : Animal 
        {
            public override void MakeSound()
            {
                Console.Write("Cat meows");
            }
        }

        //public void DemonstrateOverriding()
        //{
        //    Animal animal = new Animal();
        //    animal.MakeSound();
        //    Dog dog = new Dog();
        //    dog.MakeSound();
        //    Cat cat = new Cat();
        //    cat.MakeSound();
        //}
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound();
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
        }
    }
}
