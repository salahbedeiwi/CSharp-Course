using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileterNumbersOnly
{
    class GetUserInput
    {
        public static int FilterInputAsInt(string inputText)
        {
            string newText = "";
            //now filter string
            foreach(char c in inputText.ToCharArray())
            {
                //filter data and take off string, only numbers
                if(c == '0' || c == '1' || c == '2' || c == '3' ||
                    c == '4' || c == '5' || c == '6' || c == '7' ||
                    c == '8' || c == '9')
                newText += c; 
            //if any of the above is found as number, add it to the string newText
            }
            //if it is empty
            if (newText == "" || newText.Trim() == "")
                newText = "0"; //let it be zero
            //now make the string to be int.
            return Convert.ToInt32(newText);
        }
    }
}
