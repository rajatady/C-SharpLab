using System;
using System.Text;

namespace semester7.Program4
{
    public class Program4 : IRunner
    {
        public void Run(string[] args)
        {
            /**
             * Part 4 a - String comparison without library functions
             */
            Console.WriteLine("Please enter string 1");
            string str1 = Console.ReadLine();

            Console.WriteLine("Please enter string 2");
            string str2 = Console.ReadLine();

            if (IsSame(str1, str2))
            {
                Console.WriteLine("String 1 - {0} and String 2 {1} are same.", str1, str2);
            }
            else
            {
                Console.WriteLine("String 1 - {0} and String 2 {1} do not match.", str1, str2);
            }

            Console.WriteLine("*************** END OF PART 4 a ******************");


            /**
             * Part 4 b - String Builder Functions
             */

            StringBuilder builder = new StringBuilder("Initial Value");
            Console.WriteLine("Intial Value of the builder - " +
                              "{0}", builder.ToString());

            builder.Append(" and Appended Value .");
            Console.WriteLine("Appended Value of the builder now is " +
                              "- {0}", builder.ToString());

            builder.AppendLine("And now Appending a Line.");
            Console.WriteLine("After appending a line" +
                              " Value of the builder now is - {0}", builder.ToString());

            builder.Replace("Append", "Replace");
            Console.WriteLine("All Append words replaced with " +
                              "Replace, value - {0}", builder.ToString());

            builder.Insert(10, "Hello World");
            Console.WriteLine("String hello world inserted at index " +
                              "10, value - {0}", builder.ToString());

            builder.Clear();
            Console.WriteLine("Builder has been cleared, value - " +
                              "{0}", builder.ToString());

            Console.WriteLine("*************** END OF PART 4 b ******************");

            /**
             * Part 4 c - Nullable Types.
             */
            int? a = null;
            PrintNullableValue(a);
            a = 10;
            PrintNullableValue(a);
            a = null;
            PrintNullableValue(a);


            Console.WriteLine("*************** END OF PART 4 c ******************");
            /**
             * Part 4 d - Nullcoalescing types
             */

            int? x = null;
            PrintNullableValue(x ?? 50);
            x = 49;
            PrintNullableValue(x ?? 50);
        }

        private Boolean IsSame(string s1, string s2)
        {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            int length = Math.Max(c1.Length, c2.Length);

            try
            {
                for (int i = 0; i < length; i++)
                {
                    if (c1[i] != c2[i])
                    {
                        return false;
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
            return true;
        }

        private void PrintNullableValue(int? a)
        {
            if (a.HasValue)
            {
                Console.WriteLine("Variable has a value {0}", a);
            }
            else
            {
                Console.WriteLine("Variable is null.");
            }
        }
    }
}