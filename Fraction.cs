using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionOperations
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int n, int d)
        {
            this.Numerator = n;
            this.Denominator = d;
        }
        public Fraction(string drop)
        {
            int[] nums = drop.Split('/').Select(n => int.Parse(n)).ToArray();
            this.Numerator = nums[0];
            this.Denominator = nums[1];
        }
        public override string ToString()
        {
            if (this.Denominator == 1)

            {
                return this.Numerator.ToString();
            }
            return this.Numerator + "/" + this.Denominator;
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            return a;
        }
        private static string MixedNumber(int n, int d)
        {
            return n / d + "[" + Math.Abs(n % d) + "/" + Math.Abs(d) + "]";
        }
        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator + fr2.Numerator *
            fr1.Denominator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }
        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator - fr2.Numerator *
            fr1.Denominator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }
        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Numerator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }
        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = fr1.Numerator * fr2.Denominator;
            result.Denominator = fr1.Denominator * fr2.Numerator;

            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            return result;
        }
        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (Math.Abs(a - b) < 0.001)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (a < b)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (a >= b)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (a <= b)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (a > b)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction fr1, Fraction fr2)

        {
            return !(fr1 == fr2);
        }
        public static string operator %(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Numerator;
            int g = GCD(result.Numerator, result.Denominator);
            result.Numerator /= g;
            result.Denominator /= g;
            string answer = "Cannot be reduced to a mixed number";
            if (result.Numerator > result.Denominator)
            {
                string mixednumber = MixedNumber(result.Numerator, result.Denominator);

                return mixednumber;

            }
            return answer;
        }
    }
}
