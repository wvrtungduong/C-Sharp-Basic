using System;
using System.Collections.Immutable;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Q31()
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("Array 1: {0}", string.Join(", ", first_array));
            Console.WriteLine("Array 2: {0}", string.Join(", ", second_array));

            for (int i = 0; i < first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
        }

        static void Q32()
        {
            string str;
            str = Console.ReadLine();
            if (str.Length > 4)
            {
                Console.WriteLine(str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            }
            else
            {
                Console.WriteLine(str);
            }
        }

        static void Q33()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 || num % 7 == 0) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q34()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.StartsWith("Hello")) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q35()
        {
            Console.Write("Input first number (<100): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number (>100): ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 100 && num2 > 100) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q36() {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > -10 && num1 < 10 || num2 > -10 && num2 < 10) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q37()
        {
            string str = "PHP Tutorial";
            if (str.Substring(1,2).Equals("HP"))
            {
                Console.WriteLine(str.Substring(0,1) + str.Substring(3));
            }
        }

        static void Q38()
        {
                string str = "PHP Tutorial";
                string result = "";
                if (str[0] == 'P') result += str[0];
                if (str[1] == 'H') result += str[1];
                Console.WriteLine(result);
        }

        static void Q39()
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lowest: " + Math.Min(num1, Math.Min(num2, num3)));
            Console.WriteLine("Largest: " + Math.Max(num1, Math.Max(num2, num3)));
        }

        static void Q40()
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2) Console.WriteLine("0");
            else if (Math.Abs(20 - num1) > Math.Abs(20 - num2)) Console.WriteLine(num2);
            else Console.WriteLine(num1);
        }

        static void Q41()
        {
            Console.WriteLine("Input a string: ");
            string str = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i].Equals('w')) count ++;
            //}
            var count = str.Count(s => s == 'w');
            if (count >= 1 && count <= 3) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q42()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.Length < 4) Console.WriteLine(str.ToUpper());
            else Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4));
        }

        static void Q43()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.Length < 5) Console.WriteLine("False");
            else 
            if (str.Substring(0, 5).Equals("wwwww"))
            {
                Console.WriteLine("True");
            } else Console.WriteLine("False");
        }

        static void Q44()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            for (int i = 0;  i < str.Length; i++)
            {
                if (i % 2 == 0) Console.Write(str[i]);
            }
        }

        static void Q45()
        {
            Console.Write("Input a number: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            Console.WriteLine(array.Count(num => num == key));
        }

        static void Q46()
        {
            Console.Write("Input a number: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            if (array[0] == key || array[array.Length - 1] == key) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q47()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void Q48()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            if (array[0] == array[array.Length - 1]) Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q49()
        {
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            if (array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1])
                Console.WriteLine("True");
            else Console.WriteLine("False");
        }

        static void Q50()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static void Q51()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8 };
            Console.WriteLine(Math.Max(array[0], array[array.Length - 1]));
        }

        static void Q52()
        {
            int[] array1 = { 1, 2, 2 };
            int[] array2 = { 3, 4, 5 };
            int[] array3 = { 5, 7, 7 };
            int[] result = { array1[1], array2[1], array3[1] };
            Console.WriteLine(string.Join(", ", result));
        }

        static void Q53()
        {
            int[] array = { 1, 2, 2, 8, 8 };
            bool found = false;
            foreach (int i in array)
            {
                if (i % 2 == 1) 
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found);
        }

        static void Q54()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Century: {0}", (int)(year / 100) + ((year % 100 == 0) ? 0 : 1));
        }

        static void Q55()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8 };

            int product = 0;

            for (int i = 0; i < array.Length - 1; i ++)
            {
                if (array[i] * array[i + 1] > product) product = array[i] * array[i + 1];
            }

            Console.WriteLine(product);
        }

        static void Q56()
        {
            bool isPalindrome = false;
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            if (new string(c).Equals(str)) isPalindrome = true;
            Console.WriteLine(isPalindrome);     
        }

        static void Q57()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8 };

            int product = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * array[i + 1] > product) product = array[i] * array[i + 1];
            }

            Console.WriteLine(product);
        }

        static void Q58()
        {
            int[] array = { 1, 3, 4, 7, 9 };
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (Math.Abs(array[i] - array[i + 1]) >= 2) {
                    count += Math.Abs(array[i] - array[i + 1]) - 1;
                }
            }
            Console.WriteLine(count);
        }

        static void Q59()
        {
            int[] array = { 1, 3, 2, 5, 9, 4, 11, 29, 14, 12 };
            int x = 0;
            bool success = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                    x++;

                if (i + 2 < array.Length && array[i] >= array[i + 2])
                    x++;
            }

            if (x <= 2) success = true;
            Console.WriteLine(success);
        }

        static void Q60()
        {
            int[][] matrix = [[0, 2, 3, 2], [0, 6, 0, 1], [4, 0, 3, 0]];
            int sum = 0;
            for (int i = 0; i < matrix[0].Length; i++)
                for (int j = 0; j < matrix.Length & matrix[j][i] > 0; j++)
                    sum += matrix[j][i];
            Console.WriteLine(sum);
        }

        static void Q61()
        {
            int[] array = { 1, 3, 2, -5, 9, 4, 11, -5, 14, 12 };
            int[] num = array.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;
            Console.WriteLine(string.Join(", ", array.Select(x => x >= 0 ? num[ctr++] : -5).ToArray()));
        }

        static void Q62()
        {
            Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij"));
        }
        public static string reverse_remove_parentheses(string str)
        {
            int lid = str.LastIndexOf('(');
            if (lid == -1)
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid);
                return reverse_remove_parentheses(
                    str.Substring(0, lid) +
                    new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                    str.Substring(rid + 1)
                );
            }
        }

        static void Q63()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int num = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (int i in array)
            {
                if (i == num)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found);
        }

        static void Q64()
        {
            string file_path;
            file_path = "C:\\Users\\wvrtu\\Downloads\\Foundations of software testing - ISTQB Certification book.pdf";
            Console.WriteLine(file_path.Split('/').Last());
        }

        static void Q65()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int[] result = array.Select(e => e * array.Length).ToArray();
            Array.ForEach(result, Console.WriteLine);
        }

        static void Q66()
        {
            string str1 = "12", str2 = "40";
            Console.WriteLine(Int32.Parse(str1) > Int32.Parse(str2) ? str1 : str2);
        }

        static void Q67()
        {
            string str = "JAVASCRIPT";
            Console.WriteLine(str.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8"));
        }

        static void Q68()
        {
            string str = "JavASCRIPTaA";
            Console.WriteLine(str.Count(s => s == 'a' || s == 'A'));
        }

        static void Q69()
        {
            string str = "CAMONVIDADEN";
            bool flag = false;
            if (str.Equals(str.ToLower()) || str.Equals(str.ToUpper())) flag = true;
            Console.WriteLine(flag);
        }

        static void Q70()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.Substring(1, str.Length - 2));
        }

        static void Q71()
        {
            string str = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == (str[i + 1]))
                {
                    flag = true;
                    break;
                }
            }
            Console.WriteLine(flag);
        }

        static void Q72()
        {
            int[] array = { 2, 4, 2, 6, 4, 8 };
            bool isWholeNumber = false;
            if (array.Average() % 1 == 0)
            {
                isWholeNumber = true;
            }
            Console.WriteLine(isWholeNumber);
        }

        static void Q73()
        {
            string str = Console.ReadLine();
            Console.WriteLine(new string(str.OrderBy(x => x).ToArray()));
        }

        static void Q74()
        {
            string str = Console.ReadLine();
            Console.Write(str.Length % 2 == 0 ? "Even" : "Odd");
        }

        static void Q75()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}th odd number: {1}", n, n * 2 - 1);
        }

        static void Q76()
        {
            string word = Console.ReadLine();
            Console.WriteLine("Is '{0}' plural? {1}", word, word.EndsWith('s'));
        }

        static void Q77()
        {
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII value of {0} is: {1}", c, (int)c);
        }

        static void Q78()
        {
            int[] array = { -2, 0, 3, 4 };
            int sum = 0;
            foreach (int x in array)
            {
                sum += (int)Math.Pow(x, 2);
            }
            Console.WriteLine(sum);
        }

        static void Q79()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original value and type: {0}, {1}", num, num.GetType());
            Console.WriteLine("Original value and type: {0}, {1}", num, num.ToString().GetType());
            string str = num.ToString();
            Console.WriteLine("Original value and type: {0}, {1}", num, int.Parse(str).GetType());
        }

        static void Q80()
        {
            object[] mixedArray = new object[5];
            mixedArray[0] = 1;
            mixedArray[1] = "Wubbaboo";
            mixedArray[2] = true;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = 9.8;

            Console.WriteLine("Printing original array elements and their types:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine("Value: " + mixedArray[i] + "; Type: " + mixedArray[i].GetType());
            }

            string[] new_nums = Array.ConvertAll(mixedArray, x => x.ToString());
            Console.WriteLine("\nPrinting array elements and their types after conversion:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.WriteLine("Value: " + new_nums[i] + "; Type: " + new_nums[i].GetType());
            }
        }

        static void Q81()
        {
            string str = Console.ReadLine();
            Console.WriteLine(Regex.Replace(str, @"[^a-zA-Z]", ""));
        }

        static void Q82()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((int)(num / 10) > num % 10);
        }

        static void Q83()
        {
            string str = Console.ReadLine();
            Console.WriteLine(Regex.Replace(str, "[aeiouAEIOU]", ""));
        }

        static void Q84()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToLower().Equals(str[i].ToString())) Console.Write(i + " ");
            }
        }

        static void Q85()
        {
            double[] array = { 1, 3, 4, 5, 6, 7 };
            for (int i = 1; i <= array.Length;i++) 
            {
                double sum = 0;
                for (int j = 0; j < i; j ++)
                {
                    sum += array[j];
                }
                Console.Write(sum + " ");
            }
        }

        static void Q86()
        {
            string str = Console.ReadLine();
            Console.WriteLine("Number of letters: " + str.Count(char.IsLetter) 
                + " Number of digits: " + str.Count(char.IsDigit));
        }

        static void Q87()
        {
            bool flag = false;
            Console.WriteLine(!flag);
        }

        static void Q88()
        {
            Console.WriteLine("Input number of straight lines of the polygon: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of the interior angles (in degrees) of the polygon: {0}", 180 * (n - 2));
        }

        static void Q89()
        {
            int[] array = { 10, -11, 12, -13, 14, -18, 19, -20 };
            Console.WriteLine(string.Join(' ', array).ToArray());
            int neg = 0;
            foreach (int i in array)
            {
                if (i < 0) neg++;
            }
            Console.WriteLine("Number of negative number: " + neg);
            Console.WriteLine("Number of positive number: {0}", array.Length - neg);
        }

        static void Q90()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int ones = Convert.ToString(num, 2).Count(c => c == '1');
            int zeros = Convert.ToString(num, 2).Count(c => c == '0');
            Console.WriteLine("Number of ones: " + ones + " Number of zeros: " + zeros);
        }

        static void Q91()
        {
            object[] mixedArray = new object[6];
            mixedArray[0] = 1;
            mixedArray[1] = "Wubbaboo";
            mixedArray[2] = true;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = -121;
            mixedArray[5] = 9.8;
            int[] result = mixedArray.OfType<int>().ToArray();
            Console.WriteLine(string.Join(' ', result).ToArray());
        }

        static void Q92()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    num++;
                    i = 2;
                }
            }
            Console.WriteLine(num);
        }

        static void Q93()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Floor(Math.Sqrt(num)));
        }

        static void Q94()
        {
            string[] arr_strings = { "Padas", "Packed", "Pace", "Pacha" };

            if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1) Console.WriteLine("");

            string result = arr_strings[0];
            int i = result.Length;
            foreach (string word in arr_strings)
            {
                int j = 0;
                foreach (char c in word)
                {
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            Console.WriteLine(result.Substring(0, i));
        }

        static void Q95()
        {
            string str = "(<>";
            bool valid = false;
            Stack<char> ch = new Stack<char>();

            foreach (var item in str.ToCharArray())
            {
                if (item == '(')
                    ch.Push(')');
                else if (item == '<')
                    ch.Push('>');
                else if (item == '[')
                    ch.Push(']');
                else if (item == '{')
                    ch.Push('}');
                else if (ch.Count == 0 || ch.Pop() != item)
                    valid = false;
            }
            if (ch.Count == 0) valid = true; else valid = false;
            Console.WriteLine(valid);
        }

        static void Q96()
        {
            string str = Console.ReadLine();
            bool flag = true;
            for (int i = 1; i < str.Length; i++)
            {
                if (!str[i].Equals(str[0]))
                {
                    flag = false;
                    break;
                }
            }
            Console.WriteLine(flag);
        }
    
        static void Q97()
        {
            string str = Console.ReadLine();
            double result;
            Console.WriteLine(double.TryParse(str, out result));
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            int ctr = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
                if (ctr > 2)
                {
                    return false;
                }
            }
            return true;
        }
        static bool AreDigitsDescending(int number)
        {
            string numString = number.ToString();

            for (int i = 0; i < numString.Length - 1; i++)
            {
                if (numString[i] <= numString[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static bool AreDigitsAscending(int number)
        {
            string numString = number.ToString();

            for (int i = 0; i < numString.Length - 1; i++)
            {
                if (numString[i] >= numString[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Q98()
        {
            int count = 0;
            int num = 2;
            while (count < 50)
            {
                if (IsPrime(num) && AreDigitsDescending(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
        }

        static void Q99()
        {
            int count = 0;
            int num = 2;
            while (count < 50)
            {
                if (IsPrime(num) && AreDigitsAscending(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
        }

        public static bool checkEquality(object x, object y)
        {
            if (!x.Equals(y))
            {
                return false;
            }
            if (!x.GetType().Equals(y.GetType()))
            {
                return false;
            }
            return true;
        }
        static void Q100()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(checkEquality(str1, str2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Q100();
        }
    }
}
