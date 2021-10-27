using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FractionOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regexPattern = @"(?<firstFraction>\d+/\d+)\s(?<operator>.+)\s(?<secondFraction>\d+/\d+)";
            Regex regex = new Regex(regexPattern);
            while (input != "END")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    Fraction drop1 = new Fraction(match.Groups["firstFraction"].ToString());
                    Fraction drop2 = new Fraction(match.Groups["secondFraction"].ToString());
                    if (match.Groups["operator"].ToString() == "+")
                    {
                        Console.WriteLine(drop1 + drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "-")
                    {
                        Console.WriteLine(drop1 - drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "*")
                    {
                        Console.WriteLine(drop1 * drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "/")
                    {
                        Console.WriteLine(drop1 / drop2);
                    }
                    else if (match.Groups["operator"].ToString() == ">")
                    {
                        Console.WriteLine(drop1 > drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "<")
                    {
                        Console.WriteLine(drop1 < drop2);
                    }

                    else if (match.Groups["operator"].ToString() == "==")
                    {
                        Console.WriteLine(drop1 == drop2);
                    }
                    else if (match.Groups["operator"].ToString() == ">=")
                    {
                        Console.WriteLine(drop1 >= drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "<=")
                    {
                        Console.WriteLine(drop1 <= drop2);
                    }
                    else if (match.Groups["operator"].ToString() == "%")
                    {
                        Console.WriteLine(drop1 % drop2);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid expression");
                }
                input = Console.ReadLine();
            }

        }
        
    }
}

 
