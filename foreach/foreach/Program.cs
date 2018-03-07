using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            object[] names = { "tamer", "ahmed" };
            object[] schools = { "nhcc", "ncc", "mctc","umn" };
            int[] nums = { 1, 2, 3, 5, 6 };
            for (int y = 0; y < names.Length; y++) { Console.WriteLine(names[y]); }
            Console.WriteLine("==========================================");
            for (int x = 0; x < nums.Length; x++) { Console.WriteLine(nums[x]); }
            Console.WriteLine("==========================================");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==========================================");
            foreach (string school in schools)
            {
                Console.WriteLine(school);
            }
            Console.WriteLine("==========================================");
            string universities = "University Of Minnesota";

            char[] cName = universities.ToCharArray();
            Console.WriteLine("Number of letters in universities is => {0}", universities.Length);
            foreach(char name in cName) { Console.WriteLine(name); } 
        }
    }
}
