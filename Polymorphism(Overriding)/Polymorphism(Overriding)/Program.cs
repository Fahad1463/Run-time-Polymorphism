using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Overriding_
{
    internal class Program
    {
        class Animal
        {
            public virtual void Fly()
            {
                Console.WriteLine("Animal can fly");
            }
        }
        class Bird : Animal
        {
            public override void Fly()
            {
                Console.WriteLine("Bird can fly");
            }
        }
        class MyObj
        {
            static void Main(string[] args)
            {
                MyObj objPoly = new MyObj();
                Animal obj1 = new Bird();
                obj1.Fly();
                Animal obj2 = new Animal();
                obj2.Fly();
                Console.ReadLine();
            }
        }
    }
}
