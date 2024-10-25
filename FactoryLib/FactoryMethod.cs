using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public interface IAnimal
    {
        string Speak();
    }

    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }

    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Woof";
        }
    }

    public abstract class AnimalCreator
    {
        public abstract IAnimal CreateAnimal();

        public string AnimalInfo()
        {
            var animal = CreateAnimal();
            return $"This animal says: {animal.Speak()}";
        }
    }

    public class CatCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }

    public class DogCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
