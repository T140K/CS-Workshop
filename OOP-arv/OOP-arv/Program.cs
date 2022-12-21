using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace OOP_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en basklass Djur
            //program som hanterar djur på en zoo
            //minst fem egenskaper som alla djur delar med varandra 
            //tre metoder som djuren delar

            //det ska finnas 3 djur som ärver från djurklassen, de ska ha minst en ny egenskap vardera och en ny metod vardera

            Dog max = new Dog("Max", 4, "mamal", "dog", "male", "brown");
            Console.WriteLine(max.MakeSound()+ "\n" + max.GetInfo() + "\n" + max.Blink() + "\n" + max.Eat() + "\n" + max.Play());
            Console.WriteLine();
            PureBred buster = new PureBred("Buster", 6, "mamal", "dog", "female", "golden brown", "golden retriver");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", buster.MakeSound(), buster.GetInfo(), buster.Blink(), buster.Eat(), buster.Play(), buster.BreedInfo());
            Console.WriteLine();
            Bird perry = new Bird("Perry", 1, "bird", "parrot", "male", 0.3);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", perry.MakeSound(), perry.GetInfo(), perry.Blink(), perry.Eat(), perry.Fly());
            Console.WriteLine();
            Fish dory = new Fish("Dory", 1, "Fish", "Hippo Tang", "female", 0.4);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", dory.MakeSound(), dory.GetInfo(), dory.Blink(), dory.Eat(), dory.Roll());
        }
    }

    public class Animal
    {
        protected string? _name;
        protected double _age;
        protected string? _group;
        protected string? _species;
        protected string? _gender;

        public Animal(string name, double age, string group, string species, string gender)
        {
            this._name = name;
            this._age = age;
            this._group = group;
            this._species = species;
            this._gender = gender;
        }

        public string Blink()
        {
            return this._name + " blinks.";
        }

        public string Eat()
        {
            return "The " + this._species + " eats.";
        }

        public string GetInfo()
        {
            return "This is " + this._name + ", he is " + this._age + " years old. It is a " + this._gender + " " + this._species + " which is a " + _group + ".";
        }
    }

    class Dog : Animal
    {
        protected string _color;
        public Dog(string name, double age, string group, string species, string gender, string color) : base (name, age, group, species, gender)
        {
            this._color = color;
        }
        public string Play()
        {
            return _name + " chases his own " + _color + " tail.";
        }
        public string MakeSound()
        {
            return _name + " barks";
        }
    }
    class PureBred : Dog
    {
        protected string _breed;
        public PureBred(string name, double age, string group, string species, string gender, string color, string breed) : base(name, age, group, species, gender, color)
        {
            this._breed = breed;
        }
        public string BreedInfo()
        {
           return "This is a purebred" + _color + _breed;
        }
        public string MakeSound()
        {
           return "The howls";
        }
    }

    class Bird : Animal
    {
        protected double _wingSpan;
        public Bird(string name, double age, string group, string species, string gender, double wingSpan) : base (name, age, group, species, gender)
        {
            this._wingSpan = wingSpan;
        }

        public string Fly()
        {
           return _name + "flaps his" + _wingSpan + "meters wide wings and takes off";
        }
        public string MakeSound()
        {
           return "The bird chirps";
        }
    }

    class Fish : Animal
    {
        protected double _weight;

        public Fish(string name, double age, string group, string species, string gender, double weight) : base(name, age, group, species, gender)
        {
            this._weight = weight;
        }
        public string Roll()
        {
            return "The fish does a barrel roll!";
        }
        public string MakeSound()
        {
            return "The fish pulses";
        }
    }
}