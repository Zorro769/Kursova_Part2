using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovrPart2
{
    public class CharacterString
    {
        private string pStrStart;

        public string PStrStart
        {
            get => pStrStart;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    pStrStart = "0";
                }
                pStrStart = value;
            }
        }
        public CharacterString()
        {
            pStrStart = "Uknown";
        }
        public CharacterString(CharacterString prevObj)
        {
            PStrStart = prevObj.PStrStart;
        }
        public CharacterString(string str)
        {
            PStrStart = str;
        }
        public static CharacterString operator +(CharacterString str1, CharacterString str2)
        {
            string resultStr = str1.PStrStart + str2.PStrStart;
            CharacterString result = new CharacterString(resultStr);
            return result;
        }
        public static CharacterString operator -(CharacterString left, CharacterString right)
        {
            if (right.PStrStart.Length > left.PStrStart.Length)
            {
                throw new MyException("The second string is longer than the first string.");
            }
            int index = left.PStrStart.IndexOf(right.PStrStart);

            if (index == -1)
            {
                throw new MyException("The second string is not found in first string.");
            }
            CharacterString result = new CharacterString();

            result.PStrStart = left.PStrStart.Substring(0, index);

            result.PStrStart += left.PStrStart.Substring(index + right.PStrStart.Length);

            return result;
        }
        public static bool operator *(CharacterString obj, CharacterString obj1)
        {
            int j = 0;
            for (int i = 0; i < obj.PStrStart.Length; i++)
            {
                if (j < obj1.PStrStart.Length && obj.PStrStart[i] == obj1.PStrStart[j])
                {
                    j++;
                    if (j == obj1.PStrStart.Length)
                        return true;
                }
                else
                {
                    j = 0;
                }
            }

            return false;
        }
        public override string ToString()
        {
            return PStrStart;
        }
    }
}
