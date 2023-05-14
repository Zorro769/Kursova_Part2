using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovrPart2
{
    public class BigIntValues : CharacterString
    {
        public BigIntValues(long nr = 0)
        {
            do
            {
                PStrStart += nr % 10;
                nr /= 10;
            } while (nr != 0);
        }
        public BigIntValues(string value)
        {
            ValidateAndSetPStrStart(value);
        }
        private void ValidateAndSetPStrStart(string value)
        {
            bool isNegative = false;
            if (value.StartsWith("-") || value.EndsWith("-"))
            {
                isNegative = true;
            }

            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(value[i]) && !isNegative)
                {
                    throw new MyException("The input string contains non-numeric characters.");
                }
            }

            string paddedValue = value.PadLeft(value.Length, '0');

            char[] reversedChars = new char[paddedValue.Length];
            for (int i = 0; i < paddedValue.Length; i++)
            {
                reversedChars[i] = paddedValue[paddedValue.Length - i - 1];
            }
            string reversedValue = new string(reversedChars);

            PStrStart = reversedValue;
        }
        public BigIntValues(BigIntValues obj)
        {
            this.PStrStart = obj.PStrStart;
        }

        public static string PopBack(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return str.Substring(0, str.Length - 1);
        }
        public static string Resize(string str, int size)
        {
            if (str.Length >= size)
            {
                return str.Substring(0, size);
            }
            else
            {
                return str.PadRight(size, '0');
            }
        }
        public static BigIntValues operator +(BigIntValues left, BigIntValues right)
        {
            int divisor = 0, number = 0, i;
            bool flag = false;
            if (left.PStrStart.Contains('-') && right.PStrStart.Contains('-'))
            {
                flag = true;
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
            }
            if ((left.PStrStart.EndsWith("-")))
            {
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                if (left < right)
                {
                    right -= left;
                    return right;
                }
                else if (left > right)
                {
                    left -= right;
                    left.PStrStart = left.PStrStart.Insert(left.PStrStart.Length, "-");
                }
                else
                    left -= right;
                return left;
            }
            if ((right.PStrStart.EndsWith("-")))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left -= right;
                if (left.PStrStart[0] == '0')
                    return left;
                return left;
            }

            if (right.PStrStart.Length > left.PStrStart.Length)
            {
                for (i = left.PStrStart.Length; i < right.PStrStart.Length; i++)
                {
                    left.PStrStart += '0';
                }
            }
            char[] result = new char[left.PStrStart.Length + 1];
            for (i = 0; i < left.PStrStart.Length; i++)
            {
                if (i < right.PStrStart.Length)
                {
                    number = left.PStrStart[i] + right.PStrStart[i] + divisor - 2 * '0';
                }
                else
                {
                    number = left.PStrStart[i] - '0' + divisor;
                }
                divisor = number / 10;
                result[i] = (char)(number % 10 + '0');
            }
            if (divisor != 0)
            {
                result[left.PStrStart.Length] = (char)(divisor + '0');
                i++;
            }
            if (flag)
            {
                result[left.PStrStart.Length] = ('-');
                i++;
            }
            Array.Resize(ref result, i);
            string resultString = new string(result);
            left.PStrStart = resultString;
            return left;
        }
        public static BigIntValues operator -(BigIntValues left, BigIntValues right)
        {
            bool flag = false;
            if (left.PStrStart.EndsWith("-") && right.PStrStart.EndsWith("-"))
            {
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                if (left > right)
                    flag = true;
                if (flag)
                {
                    left -= right;
                    left.PStrStart += "-";
                }
                else
                {
                    right -= left;
                    left = right;
                }
                if (left.PStrStart[left.PStrStart.Length] == '0')
                    left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                return left;
            }
            else if (left.PStrStart.EndsWith("-"))
            {
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                left += right;
                left.PStrStart += "-";
                return left;
            }
            else if (right.PStrStart.EndsWith("-"))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left += right;
                return left;
            }
            if (left < right)
            {
                right -= left;
                right.PStrStart = right.PStrStart.Insert(right.PStrStart.Length, "-");
                return right;
            }
            int i, t = 0, number;
            char[] result = new char[left.PStrStart.Length];
            for (i = 0; i < Math.Max(left.PStrStart.Length, right.PStrStart.Length); i++)
            {
                if (i < right.PStrStart.Length && !flag)
                    number = (left.PStrStart[i] - '0') - (right.PStrStart[i] - '0') + t;
                else if (flag)
                    number = right.PStrStart[i] - '0' - left.PStrStart[i] - '0' + t;
                else
                    number = left.PStrStart[i] - '0' + t;

                if (number < 0)
                {
                    number += 10;
                    t = -1;
                }

                else
                    t = 0;

                result[i] = (char)(number + '0');
            }
            Array.Resize(ref result, i);
            while (result.Length > 1 && result[i - 1] == '0')
            {
                Array.Resize(ref result, result.Length - 1);
                i--;
            }

            if (flag)
                result[left.PStrStart.Length] = ('-');
            string resultString = new string(result);
            left.PStrStart = resultString;
            return left;
        }
        public static BigIntValues operator *(BigIntValues left, BigIntValues right)
        {
            BigIntValues result = new BigIntValues(left);
            if (left.PStrStart == "0" || right.PStrStart == "0")
            {
                left = new BigIntValues("0");
                return left;
            }
            if (left.PStrStart.Contains('-') && right.PStrStart.Contains('-'))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                left = left * right;
                return left;
            }
            else if ((left.PStrStart.EndsWith("-")))
            {
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                left *= right;
                left.PStrStart = left.PStrStart.Insert(left.PStrStart.Length, "-");
                return left;
            }
            else if ((right.PStrStart.EndsWith("-")))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left *= right;
                left.PStrStart = left.PStrStart.Insert(left.PStrStart.Length, "-");
                return left;
            }
            List<int> list = Enumerable.Repeat(0, left.PStrStart.Length + right.PStrStart.Length).ToList();
            for (int i = 0; i < left.PStrStart.Length; i++)
                for (int j = 0; j < right.PStrStart.Length; j++)
                {
                    list[i + j] = list[i + j] + (left.PStrStart[i] - '0') * (right.PStrStart[j] - '0');
                }
            result.PStrStart = Resize(result.PStrStart, list.Count());
            char[] temp = new char[result.PStrStart.Length];
            for (int s, i = 0, t = 0; i < result.PStrStart.Length; i++)
            {
                s = t + list[i];
                list[i] = s % 10;
                t = s / 10;
                temp[i] = (char)(list[i] + '0');
            }
            for (int i = result.PStrStart.Length - 1; i >= 1 && list[i] == 0; i--)
                Array.Resize(ref temp, temp.Length - 1);
            string resultString = new string(temp);
            result.PStrStart = resultString;
            return result;
        }
        public static BigIntValues operator /(BigIntValues left, BigIntValues right)
        {
            if (right.PStrStart == "0")
                throw new MyException("Arithmetic Error: Division By 0");
            if (Module(left) < Module(right))
            {
                return new BigIntValues("0");
            }
            if (left == right)
            {
                return new BigIntValues("1");
            }
            if (left.PStrStart.Contains('-') && right.PStrStart.Contains('-'))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                left = left / right;
                return left;
            }
            else if ((left.PStrStart.EndsWith("-")))
            {
                left.PStrStart = BigIntValues.PopBack(left.PStrStart);
                left /= right;
                left.PStrStart = left.PStrStart.Insert(left.PStrStart.Length, "-");
                return left;
            }
            else if ((right.PStrStart.EndsWith("-")))
            {
                right.PStrStart = BigIntValues.PopBack(right.PStrStart);
                left /= right;
                left.PStrStart = left.PStrStart.Insert(left.PStrStart.Length, "-");
                return left;
            }
            int lgcat = 0, cc;
            int i = 0;
            List<int> list = Enumerable.Repeat(0, left.PStrStart.Length).ToList();
            BigIntValues t = new BigIntValues("0");
            BigIntValues multiplier = new BigIntValues("10");
            BigIntValues additionalMultiplier;
            i = left.PStrStart.Length - 1;
            while (true)
            {
                BigIntValues tmp = new BigIntValues(t);
                tmp = tmp * multiplier + new BigIntValues(left.PStrStart[i].ToString());
                if (tmp >= right)
                    break;
                t = (t * multiplier) + new BigIntValues(left.PStrStart[i].ToString());
                i--;
            }
            for (; i >= 0; i--)
            {
                BigIntValues tmp = new BigIntValues(t);
                t = tmp * multiplier + new BigIntValues(left.PStrStart[i].ToString());
                additionalMultiplier = new BigIntValues("9");
                for (cc = 9; additionalMultiplier * right > t; cc--, additionalMultiplier.PStrStart = cc.ToString()) { }
                t -= additionalMultiplier * right;
                list[lgcat++] = cc;
            }
            char[] temp = new char[lgcat];
            for (i = 0; i < lgcat; i++)
                temp[i] = (char)(list[lgcat - i - 1] + '0');
            string resultString = new string(temp);
            left.PStrStart = resultString;
            return left;
        }
        public static bool operator <(BigIntValues left, BigIntValues right)
        {
            bool flag = false;
            if (left.PStrStart.EndsWith("-") && right.PStrStart.EndsWith("-"))
                flag = true;
            else if (left.PStrStart.EndsWith("-"))
                return true;
            else if (right.PStrStart.EndsWith("-"))
                return false;
            if (left.PStrStart.Length != right.PStrStart.Length && !flag)
                return left.PStrStart.Length < right.PStrStart.Length;
            int size = left.PStrStart.Length;
            while ((size--) != 0)
                if (flag)
                {
                    size--;/////
                    return left.PStrStart[size] > right.PStrStart[size];
                }
                else if (left.PStrStart[size] != right.PStrStart[size])
                    return left.PStrStart[size] < right.PStrStart[size];
            return false;
        }
        public static bool operator >(BigIntValues left, BigIntValues right)
        {
            return right < left;
        }
        public static bool operator >=(BigIntValues left, BigIntValues right)
        {
            return !(left < right);
        }
        public static bool operator <=(BigIntValues left, BigIntValues right)
        {
            return !(left > right);
        }
        public static bool operator ==(BigIntValues left, BigIntValues right)
        {
            if (left.PStrStart == right.PStrStart)
                return true;
            return false;
        }
        public static bool operator !=(BigIntValues left, BigIntValues right)
        {
            return !(left == right);
        }
        private static BigIntValues Module(BigIntValues obj)
        {
            string modifiedString = " ";
            if (obj.PStrStart.EndsWith("-"))
                modifiedString = obj.PStrStart.Substring(0, obj.PStrStart.Length - 1);
            else
                return obj;
            BigIntValues temp = new BigIntValues();
            temp.PStrStart = modifiedString;
            return temp;
        }
        public override string ToString()
        {
            char[] charArray = this.PStrStart.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
