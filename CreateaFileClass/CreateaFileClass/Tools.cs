using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //CALL THE FOLDER NAMESPACE
namespace CreateaFileClass
{
    class Tools
    {
        //create folder
        public static void CreateFolder(string addFolderName)
        {
            if (!Directory.Exists(addFolderName))
                Directory.CreateDirectory(addFolderName);
        }
        //create folders
        public static void CreateFolders(string[] foldersName)
        {
            foreach (string folder in foldersName)
            {
                if(!Directory.Exists(folder))
                    CreateFolder(folder);
            }
        }
        //create empty file
        public static void CreateEmptyFile(string fileName)
        {
            //check that file is not existing
            if (!File.Exists(fileName))
            {
                //if not exists:
                File.Create(fileName).Close();
                //Create() => create the file and use it
                //Close() => close it right away after creating it
                 
            }
        }
        //create empty files
        public static void CreateFiles(string[] createFiles)
        {
            foreach(string file in createFiles)
            {
                CreateEmptyFile(file);
            }
        }
        //how to add data to my files.
        //get data to add and the file name to push the data into
        public static void PushDataToFile(string fileName, string[] addData)
        {
            //create file: add a text to file
            StreamWriter sw = new StreamWriter(fileName);
            foreach(String data in addData)
            {
                sw.WriteLine(data);
            }
            sw.Close();
        }
        public static void PushDataToFiles(string[] fileNames, string[][] addData)
        {
            //create file: add a text to file

            for (int x = 0; x < fileNames.Count(); x += 1)
            {
                PushDataToFile(fileNames[x], addData[x]);
            }
        }

    }
}
