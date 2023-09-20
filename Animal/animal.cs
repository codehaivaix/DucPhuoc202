
using System.Dynamic;

namespace DucPhuoc{
    class Program{
       public abstract class Animal{
        protected string weight{get;set;}
        protected string height{get;set;}
        public Animal(string weight,string height){
            this.weight = weight;
            this.height = height;
        }
        public abstract void Printifo();
       }
       class Cat : Animal{
        private String Name{get ; set;}
        public Cat(string weight,string height,string Name):base(weight,height){
            this.Name = Name;
        }
            public override void Printifo()
            {
                Console.WriteLine(this.weight);
                Console.WriteLine(this.height);
                Console.WriteLine(this.Name);
            }

        }
        static void Main(string[] args){
         Cat cat = new Cat("10kg"," 2 ","kitty");
         cat.Printifo();
    }
    }
}