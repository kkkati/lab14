using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кот");
            cat.ShowInfo();
            Dog dog = new Dog("собака");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        //абстрактное свойствосвойство
        public abstract string Name { get; set; }

        //конструктор, устанавливающий значение по умолчанию
        public Animal(string name="Кот")
        {
            Name = name;
        }

        //абстрактный метод Say
        public abstract void Say();

        //неабстрактный метод ShowInfo
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat:Animal
    {
        //поле и свойство
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        //вызов базового конструктора
        public Cat(string name)
            :base(name)
        {

        }

        //метод say
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        //поле и свойство
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        //вызов базового конструктора
        public Dog(string name)
            : base(name)
        {

        }

        //метод say
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }

}
