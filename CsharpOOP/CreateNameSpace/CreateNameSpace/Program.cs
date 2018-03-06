using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO; //ADD THIS NAMESPACE FOR FILES
using CreateTestNamespace;
//call FirstClass.cs namespaces
using Parents.Children.FemaleChild.ChildName;
using Parents.Children.MaleChild.ChildName;
using Parents.Dad;
namespace CreateNameSpace
{
    /*
     * You can call as many namespaces
     * to add namespace
     *              => create another class, change the namespace of it or have it the same
     *              => if different namespace, then add it above => using namespaceName
     *              => if same namespace, then you don't need to add
     * using namespaceFamily.namespaceParent.namespaceChildren.namespaceFirstChild.namespaceGender.....
     * using namespaceCompany.nameSpaceBuilding.nameSpaceDepartment....
     * Note: 
     * if you have Parents.Children => means i can only only only access anything on Children namespace
     * means 
     *  => I can't just call Parents.Class wrooooong, but i can do Parents.Children.classIfFound
     * so using namesspaces, only have the accessibility to the last namespace on your statment
     * Ex:
     * using Parents.Children.FemaleChild; => only FemaleChild classes and methods
     * using Parents.Children.MaleChild.ChildName; => => only ChildName classes and methods
     *                                              => can't access any class on MaleChild
     *                                              => solve: using Parents.Children.MaleChild (good now) 
     *                                              
     * */
    class Program
    {
        //private method Main()
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("Create a namespace");
            Console.WriteLine("=====================================================");
            Console.Write(File.Exists("Program.cs"));
            // can i call the classes from another page
            Parents.FirstClass p = new Parents.FirstClass(); //I can create an instance of it
            CreateTestNamespace.Test c = new CreateTestNamespace.Test(); //I can call name space
            Test dee = new Test(); //I can call name space
            //i can also use keyword using
            // namespaceName.ClassName
            /*
             * Here, I am accessing the class name, why? 
             * Because it has the same namespace.
             * 
             *
            */
            //call classes from FirstClass.cs that have namespaces added up on the page
            //access classes directly, why? becuase i included namespaces above
            MaleChild.MyMaleChild();
            //access classes directly, why? becuase i included namespaces above
            FemaleChild.MyFemaleChild();
            //why I have to add the namespaces below, because i didn't include them above
            Dad.MyDad();
            Parents.Mom.Mom.MyMom(); //i didn't include it above
            Console.ReadKey();
        }
    }
}
