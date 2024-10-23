using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OBMiS_lab3
{
    public static class CountingHandler
    {
        private static string binBuffer = "";
        private static bool neg = false;
        
        public static string Convert(string value, int source, int target)
        {
            //char[] numbers = value.ToCharArray();
            string res = "";

            
            Check(value, source);
            if (neg) 
            { 
                res += "-";
                value = value.Remove(0, 1);
            }
            
            if (source == target) 
            {
                binBuffer = value;
                //string temp = neg ? "-" + value : value;
                return value; 
            }
            
            binBuffer = FromDec(ToDec(value, source), target);
            res += binBuffer;
            
            return res;
        }

        private static void Check(string value, int source)
        {
            char[] numbers = value.ToCharArray();
            if (value[0] == '-')
            {
                value.Remove(0, 1);
                neg = true;
            }
            else
            {
                neg = false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Char.IsLetter(numbers[i]))
                {
                    if (LetterToNumber(numbers[i]) >= source || LetterToNumber(numbers[i]) == 0) throw new ArgumentException("Неверный ввод");
                }
                else if (Char.IsDigit(numbers[i]) && numbers[i] - '0' >= source)
                {
                    throw new ArgumentException("Неверный ввод");
                }

            }
        }

        private static string padLeft(string value, int length)
        {
            StringBuilder sb = new StringBuilder(value);
            while (sb.Length < length)
            {
                sb.Insert(0, "0");
            }
            return sb.ToString();
        }

        private static string additionalCode(string value, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb.Append(value[i] == '0' ? '1' : '0');
            }
            return padLeft(BinAdd(sb.ToString(), "1"), length);
        }

        private static int CompareBin(string x, string y)
        {
            x = x.TrimStart('0');
            y = y.TrimStart('0');
            if (x == "") x = "0";
            if (y == "") y = "0";
            if (x.Length > y.Length) return 1;
            if (y.Length > x.Length) return -1;
            return string.Compare(x, y, StringComparison.Ordinal);
        }

        public static string BinAdd(string x, string y)
        {
            
            StringBuilder res = new StringBuilder();
            int carry = 0;
            int maxLen = Math.Max(x.Length, y.Length);
            x = padLeft(x, maxLen);
            y = padLeft(y, maxLen);

            for (int i = maxLen - 1; i >= 0; i--)
            {
                int bitX = x[i] - '0';
                int bitY = y[i] - '0';
                int sum = bitX + bitY + carry;
                res.Insert(0, sum % 2);
                carry = sum / 2;
            }
            if (carry > 0)
            {
                res.Insert(0, carry);
            }

            return res.ToString();
        }

        public static string BinSub(string x, string y)
        {
            string yAdditional = additionalCode(y, x.Length);
            return BinAdd(x, yAdditional)[1..];
        }

        public static string BinMult(string x, string y)
        {
            string res = "0";
            int len = y.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (y[i] == '1')
                {
                    res = BinAdd(res, x + new string('0', len - i - 1));
                }
            }

            return res;
        }

        public static string BinDiv(string x, string y)
        {
            StringBuilder sb = new StringBuilder();
            string buff = "0";

            for (int i = 0; i < x.Length; i++)
            {
                buff = BinAdd(buff + x[i], "0");

                if (CompareBin(buff, y) >= 0)
                {
                    sb.Append("1");
                    buff = BinSub(buff, y);
                }
                else
                {
                    sb.Append("0");
                }
            }
            return sb.ToString();
        }

        public static string Add(string value1, string value2, int source)
        {
            Check(value1, source);
            Check(value2, source);
            int x = ToDec(value1, source);
            int y = ToDec(value2, source);
            return FromDec(x + y, source);
        }

        public static string Sub(string value1, string value2, int source)
        {
            Check(value1, source);
            Check(value2, source);
            int x = ToDec(value1, source);
            int y = ToDec(value2, source);
            return FromDec(x - y, source);
        }

        public static string Mult(string value1, string value2, int source)
        {
            Check(value1, source);
            Check(value2, source);
            int x = ToDec(value1, source);
            int y = ToDec(value2, source);
            return FromDec(x * y, source);
        }

        public static string Div(string value1, string value2, int source)
        {
            Check(value1, source);
            Check(value2, source);
            int x = ToDec(value1, source);
            int y = ToDec(value2, source);
            if (y == 0) throw new DivideByZeroException();
            return FromDec((x / y), source);
        }

        private static int ToDec(string number, int source)
        {
            int resValue = 0;
            int power = 1;
            for (int i = number.Length - 1; i >= 0;i--)
            {
                if (Char.IsLetter(number[i]) && LetterToNumber(number[i]) != 0)
                {
                    resValue += LetterToNumber(number[i]) * power;
                }
                else
                {
                    resValue += (number[i] - '0') * power;
                }
                power *= source;
            }
            return resValue;
        }

        private static string FromDec(int number, int target)
        {
            if (number == 0)
            {
                return "0";
            }
            List<char> res = new List<char>();
            while (number > 0)
            {
                int digit = number % target;
                number /= target;

                if (digit < 10)
                {
                    res.Add((char)('0' + digit));
                }
                else
                {
                    res.Add((char)('A' + digit - 10));
                }
                
            }
            res.Reverse();
            return new string(res.ToArray());
        }

        public static string ToPlainCode()
        {
            string res = "";
            int len = binBuffer.Length;
            int pow = 0;
            for (int i = 1; i <= 32; i *= 2) 
            {
                pow++;
                if (len / i <= 1)
                {
                    break;
                }
            }
            int numZeros = (int)Math.Pow(2, pow) - len % (int)Math.Pow(2, pow) - 1;
            if (neg)
            {
                res += "1";
            }
            else
            {
                res += "0";
            }
            for (int i = 0; i < numZeros; i++)
            {
                res += "0";
            }
            res += binBuffer;
            neg = false;
            binBuffer = "";
            return res;
        }

        private static int LetterToNumber(char c)
        {
            switch (c)
            {
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
            }
            return 0;
        }
    }
}
