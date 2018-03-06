using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parents
{
    class FirstClass
    {
        public static void MyFirstClass()
        {
            Console.WriteLine("Welcome from my first class.");
        }
    }
    namespace Dad
    {
        class Dad
        {
            public static void MyDad()
            {
                Console.WriteLine("Welcome from my first Dad's class.");
            }
        }
    }
    namespace Mom
    {
        class Mom
        {
            public static void MyMom()
            {
                Console.WriteLine("Welcome from my first Mom's class.");
            }
        }
    }
    namespace Children
    {
        namespace FemaleChild
        {
            namespace ChildName
            {
                class FemaleChild
                {
                    public static void MyFemaleChild()
                    {
                        Console.WriteLine("Welcome from my first FemaleChild's class.");
                    }
                }
            }
        }
        namespace MaleChild
        {
            namespace ChildName
            {
                class MaleChild
                {
                    public static void MyMaleChild()
                    {
                        Console.WriteLine("Welcome from my first MaleChild's class.");
                    }
                }
            }
        }
    }
}
