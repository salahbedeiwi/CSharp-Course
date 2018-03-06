        using System;
        namespace StaticVsNonStatic
        {
            class Person
            {
                public int id;
                public static string name;
                public string address;

                public void PrintData()
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Address: {2}", 
                                            id, name, address);
                }
                public void printName()
                {
                    Console.WriteLine("Name: {0}", name);
                }
                public static void justCALLMe()
                {
                    Console.WriteLine("Name: {0}!", name);
                }
                //note when using static keyword below,
                // any param must be static as well 
                public void PrintAddress()
                {
                    Console.WriteLine("Address: {0}", address);
                    //address must be defined as static
                }
                //can i access this without creating an object?
                // no i can't, only static methods & attributes
                //this is a constructor,, non static
                //non static means: will not work directly
                //static can be called directly
                //do my attributes must be static??????
                //No we don't have too!
                public Person()
                {
                    name = "Salah";
                    Console.WriteLine("{0}, This will have any person info!",
                            name);
                }
            }
        }
