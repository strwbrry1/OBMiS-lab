using System;
using System.Collections.Generic;
using System.Linq;
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
            char[] numbers = value.ToCharArray();
            string res = "";

            //int power = numbers.Length;
            if (value[0] == '-')
            {
                res = "-";
                value = value.Remove(0, 1);
                neg = true;
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
            int numZeros = 4 - binBuffer.Length % 4 - 1;
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
