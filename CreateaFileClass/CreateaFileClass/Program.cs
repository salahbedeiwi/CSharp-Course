using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateaFileClass
{
    class Program
    {
        void sayHi()
        {

        }
        static void CreateFolders(string[] foldersName)
        {
            foreach(string folder in foldersName)
            {
                Tools.CreateFolder(folder);
            }
        }
        static void Main(string[] args)
        {
            
            //now call the static class directly
            //note, you will find it on 
            // solutions folder -> bin -> debug
            Tools.CreateFolder("MyFirstFolder");
            //create folders:
            string[] allFolders = new string[] { "Salah", "Say Hi", "Folder 2" };
            CreateFolders(allFolders);
            //create an empty file:
            Tools.CreateEmptyFile("EmptyFile.cs");
            //create empty files
            string[] allFiles = new string[] { "Salah.css", "SayHi.css", "Folder2.cs" };
            Tools.CreateFiles(allFiles);
            //add data to file:
            Tools.PushDataToFile("My New File.txt", 
                                new string[] { "Hello", "Salah", "Welcome"});
            //add data to many files:
            string[] fileNames = { "file1.txt", "file2.txt", "file3.txt" };
            string[] line1 = { "Hey1", "Hola1", "Hi1" };
            string[] line2 = { "Hey2", "Hola2", "Hi2" };
            string[] line3 = { "Hey3", "Hola3", "Hi3" };
            string[][] all = { line1, line2, line3 };
            Tools.PushDataToFiles(fileNames, all);






            Console.ReadKey();
        }
    }
}
