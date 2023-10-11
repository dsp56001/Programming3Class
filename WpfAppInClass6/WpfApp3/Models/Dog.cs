using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public interface IBarkable
    {
        string BarkSound { get; set; }
        string Bark();
    }

    public interface IEat
    {
        int Weight { get; set; }
        void Eat();
        void Poop();
    }

    public interface IAboutable
    {
        string Name { get; set; }
        string About();
    }

    public interface IDog : IBarkable, IEat, IAboutable
    { 
    
    }

    public class Dog : IDog 
    {
        //Private instance data members
        protected string name;
        protected int age;
        protected int weight;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                
                this.name = value;
                
            }
        }
        public int Age {
            get
            {
                return this.age;
            }
            set
            {
                age = value;
                
    
            } 
        }
        public int Weight { get { return this.weight; } 
            set 
            { 
                this.weight = value;
                
            } 
        }
        public string BarkSound { get; set; }

        public Dog()
        {

            this.Name = "fido";
            this.Age = 1;
            this.Weight = 1;
            this.BarkSound = "woof!";
        }

        public string About()
        {
            return $"Hello my name is {this.Name}";
        }

        public string Bark()
        {
            return this.BarkSound;
        }

        public void Eat()
        {
            this.Weight++;
        }

        public void Eat(int HowMuch)
        {
            for (int i = 0; i < HowMuch; i++)
            {
                this.Eat();
            }
        }

        public void Poop()
        {
            this.Weight--;
        }

        
    }
}
