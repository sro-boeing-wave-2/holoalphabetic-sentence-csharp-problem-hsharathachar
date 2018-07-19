using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int count=0;
            input = input.ToLower();
            string inp = new string( input.Distinct().ToArray() );
            for(int i=0; i<inp.Length; i++)
                {
                for(int j=0; j<alphabets.Length; j++)
                    {
                    if(inp[i] == alphabets[j])
                        {
                        count++;
                        break;
                        }
                    }
                if(count == 26)
                    {
                    break;
                    }
                }

            if(count == 26)
                {
                return true;
                }

            else
                {
                return false;
                }
        }
    }
}
