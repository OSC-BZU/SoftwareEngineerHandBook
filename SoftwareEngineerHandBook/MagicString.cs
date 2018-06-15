using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class MagicString
    {
        string[] vowels = new string[] { "a", "e", "i", "o", "u" };
        List<string> magicList = new List<string>();
        int _n;
        public MagicString(int n)
        {
            Console.WriteLine(n + " length sub strings will be produced and count in respect a can be followed only by e, so that, e -> a or i , i -> a,e,o,u ; o > i or u ; u ->a");
            _n = n;
            foreach (string s in vowels)
                getMagicString(s, n);

            Console.WriteLine("Total magic " + magicList.Count);
        }

        public void getMagicString(string startChar,int path)
        {
            
            if (path == 1)
            {
                if (!magicList.Contains(startChar) )
                {
                    magicList.Add(startChar);
                }
                return;
                
            }
            if(startChar[startChar.Length-1] == 'a')
            {
                 getMagicString(startChar +"e", path - 1);

            }
            if (startChar[startChar.Length-1] == 'e')
            {
                getMagicString(startChar + "a", path - 1);
                getMagicString(startChar + "i", path - 1);
            }
            if (startChar[startChar.Length-1] == 'i')
            {
                getMagicString(startChar + "a", path - 1);
                getMagicString(startChar + "e", path - 1);
                getMagicString(startChar + "o", path - 1);
                getMagicString(startChar + "u", path - 1);
            }
            if (startChar[startChar.Length-1] == 'o')
            {
                getMagicString(startChar + "i", path - 1);
                getMagicString(startChar + "u", path - 1);
            
            }
            if (startChar[startChar.Length-1] == 'u')
            {
                getMagicString(startChar + "a", path - 1);

            }
        }
    }
}
