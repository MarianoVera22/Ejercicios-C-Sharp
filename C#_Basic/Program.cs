//public class Excercise1
//{
//    public static void Main() {
//        System.Console.WriteLine("Hello");
//        System.Console.WriteLine("Mariano Vera Causich!");
//    }
//}

//public class Excercise2
//{
//    public static void Main()
//    {
//        System.Console.WriteLine(87+45);
//    }
//}

//public class Excercise3
//{
//    public static void Main()
//    {
//        System.Console.WriteLine(86 / 2);
//    }
//}

//public class Excercise4
//{
//    public static void Main()
//    {
//        System.Console.WriteLine(-1 + (4*6));
//        System.Console.WriteLine((35+5)%7);
//        System.Console.WriteLine(14 + (-4) * 6 / 11);
//        System.Console.WriteLine(2 + (15 / 6 * 1) - (7 % 2)); 
//    }
//}

//using System;
//public class Excercise6
//{
//    public static void Main(string[] args)
//    {
//        int number1, number2, aux;

//        Console.Write("\nInput the first number: ");
//        number1 = int.Parse(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        number2 = int.Parse(Console.ReadLine());

//        aux = number1;
//        number1 = number2;
//        number2 = aux;

//        Console.Write("\nAfter swapping: ");
//        Console.Write("\nFirst number: "+ number1);
//        Console.Write("\nSecond number: " + number2);

//        Console.Read();
//    }
//}

//using System;
//public class Excercise6
//{
//    public static void Main(string[] args)
//    {
//        int number1, number2, number3, result;

//        Console.Write("\nInput the first number: ");
//        number1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        number2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the third number: ");
//        number3 = Convert.ToInt32(Console.ReadLine());

//        result = number1 * number2 * number3;
//        Console.WriteLine("\nMultiply: {0} x {1} x {2} = {3}", number1, number2, number3, result);

//    }
//}

//using System;
//public class Excercise7
//{
//    public static void Main(string[] args)
//    {
//        int num1, num2;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\nAdding: {0} + {1} = {2}",num1, num2, num1 + num2);
//        Console.WriteLine("\nSubtracting: {0} - {1} = {2}", num1, num2, num1 - num2);
//        Console.WriteLine("\nMultiplying: {0} * {1} = {2}", num1, num2, num1 * num2);
//        Console.WriteLine("\nDividing: {0} / {1} = {2}", num1, num2, num1 / num2);

//    }
//}

//using System;
//public class Excercise8
//{
//    public static void Main(string[] args)
//    {
//        int num1;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());


//        Console.WriteLine("\n{0} * {1} = {2}", num1 , 1 , num1*1);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 2, num1 * 2);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 3, num1 * 3);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 4, num1 * 4);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 5, num1 * 5);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 6, num1 * 6);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 7, num1 * 7);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 8, num1 * 8);
//        Console.WriteLine("\n{0} * {1} = {2}", num1, 9, num1 * 9);

//    }
//}

//using System;
//public class Excercise9{
//    public static void Main(string[] args)
//    {
//        int num1, num2, num3, num4, result;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the third number: ");
//        num3 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the fourth number: ");
//        num4 = Convert.ToInt32(Console.ReadLine());

//        result = (num1 + num2 + num3 + num4) / 4;

//        Console.WriteLine("\nAverage of {0}, {1}, {2}, {3} is: {4}", num1, num2, num3, num4, result);
//    }
//}

//using System;
//public class Excercise10
//{
//    public static void Main(string[] args)
//    {
//        int num1, num2, num3;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the third number: ");
//        num3 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\n ({0} + {1}) * {2} = {3}", num1, num2, num3,(num1 + num2) * num3);
//        Console.WriteLine("\n {0} * {1} + {1} * {2} = {3}", num1, num2, num3, (num1 * num2) + (num2 * num3));
//    }
//}

//using System;
//public class Excercise11
//{
//    public static void Main(string[] args)
//    {
//        int num1;

//        Console.Write("\nEnter your age: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\nYou look younger than {0}", num1);
//    }
//}


//using System;
//public class Excercise12
//{
//    public static void Main(string[] args)
//    {
//        int num1;

//        Console.Write("\nInput the number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\n{0} {0} {0} {0}" +
//                            "\n{0}{0}{0}{0}"+
//                            "\n{0} {0} {0} {0}"+
//                            "\n{0}{0}{0}{0}", num1);
//    }
//}

//using System;
//public class Excercise13
//{
//    public static void Main(string[] args)
//    {
//        int num1;

//        Console.Write("\nInput the number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\n{0}{0}{0}" +
//                            "\n{0} {0}" +
//                            "\n{0} {0}" +
//                            "\n{0} {0}" +
//                            "\n{0}{0}{0}", num1);
//    }
//}

//using System;
//public class Excercise14
//{
//    public static void Main(string[] args)
//    {
//        int tempC,tempK,tempF;

//        Console.Write("\nInput the temperature in Celsius: ");
//        tempC = Convert.ToInt32(Console.ReadLine());

//        tempK = tempC + 273;
//        tempF = (tempC * 18 / 10) + 32;

//        Console.WriteLine("\nCelsius: {0}",tempC);
//        Console.WriteLine("\nKelvin: {0}", tempK);
//        Console.WriteLine("\nFarenheit: {0}", tempF);
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise15
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(remove_char("w3resource", 1));
//        Console.WriteLine(remove_char("w3resource", 9));
//        Console.WriteLine(remove_char("w3resource", 0));

//    }

//    public static string remove_char(string str, int n) {
//        return str.Remove(n, 1);
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise16
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(first_last("w3resource"));
//        Console.WriteLine(first_last("Mariano"));
//        Console.WriteLine(first_last("C"));
//    }

//    public static string first_last(string ustr)
//    {
//        return ustr.Length > 1
//            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
//            : ustr;
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise17
//{
//    public static void Main(string[] args)
//    {
//        string str;

//        Console.Write("\nInput the string: ");
//        str = Console.ReadLine();

//        if (str.Length >= 1) {

//            var s = str.Substring(0, 1);

//            Console.WriteLine(s + str + s);
//        }
//    } 
//}

//using System;
//using System.Collections.Generic;
//public class Excercise18
//{
//    public static void Main(string[] args)
//    {
//        int num1, num2;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        //if (num1 > 0) 
//        //{
//        //    if (num2 < 0) 
//        //    {
//        //        Console.Write("\nTrue");
//        //    }
//        //    else
//        //    {
//        //        Console.Write("\nFalse");
//        //    }
//        //}

//        //if (num2 > 0)
//        //{
//        //    if (num1 < 0)
//        //    {
//        //        Console.Write("\nTrue");
//        //    }
//        //    else 
//        //    {
//        //        Console.Write("\nFalse");
//        //    }
//        //}

//        Console.WriteLine((num1 < 0 && num2 > 0) || (num2 > 0 && num1 < 0));

//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise19
//{
//    public static void Main(string[] args)
//    {
//        int num1, num2, result;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        if (num1 == num2)
//        {
//            result = (num1 + num2) * 3;
//        }
//        else {
//            result = num1 + num2;
//        }

//        Console.WriteLine("Result: {0}",result);

//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise20
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(result(50, 120));
//        Console.WriteLine(result(150, 120));
//        Console.WriteLine(result(0, 120));
//    }

//    public static int result(int a, int b) 
//    {
//        if (a > b) 
//        {
//            return (a - b) * 2;
//        }
//        return b - a;
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise21
//{
//    public static void Main(string[] args) 
//    {
//        int num1, num2;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine(num1 == 20 || num2 == 20 || (num1 + num2 == 20));
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise22
//{
//    public static void Main(string[] args)
//    {
//        int num1;

//        Console.Write("\nInput the first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine((num1 >= 20 && num1 <= 100) || (num1 == 200));
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise23
//{
//    public static void Main(string[] args)
//    {
//        string line = "Mi mama me mima";

//        Console.WriteLine(line.ToLower());
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise23
//{
//    public static void Main(string[] args)
//    {
//        string line = "Mi mama me mima";

//        Console.WriteLine(line.ToLower());
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise24
//{
//    public static void Main(string[] args)
//    {
//        string line = "Lo esencial es invisible a los ojos";

//        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);


//        string word ="";
//        int i = 0;

//        foreach (String s in words) 
//        {
//            if (s.Length > i) 
//            {
//                word = s;
//                i = s.Length;
//            }        
//        }

//        Console.WriteLine(word);
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise25
//{
//    public static void Main(string[] args)
//    {
//        for (int i = 1; i < 100; i++)
//        {
//            if (i % 2 != 0) 
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise26
//{
//    public static void Main(string[] args)
//    {
//        int sum = 0;
//        int i = 0;
//        int n = 2;

//        while (i < 500) 
//        {
//            if (isPrime(n)) 
//            {
//                sum += n;
//                i++;
//            }
//            n++;
//        }
//        Console.WriteLine(sum);
//    }

//    public static bool isPrime(int n)
//    {
//        int x = (int)Math.Floor(Math.Sqrt(n));

//        if (n == 1) return false;
//        if (n == 2) return true;

//        for (int i = 2; i <= x; i++)
//        {
//            if (n % i == 0) return false;
//        }

//        return true;
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise27
//{
//    public static void Main(string[] args)
//    {
//        int sum = 0;

//        Console.Write("\nInput the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        while (num1 != 0) 
//        {
//            sum += num1 % 10;
//            num1 /= 10;
//        }

//        Console.WriteLine("Sum of the digits of the said integer: " + sum);
//    }
//}

//using System;
//using System.Collections.Generic;
//public class Excercise28
//{
//    public static void Main(string[] args)
//    {
//        string line = "Lo esencial es invisible a los ojos";
//        Console.WriteLine("\nOriginal String: " + line);

//        string result = "";
//        List<string> wordsList = new List<string>();

//        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

//        for (int i = words.Length - 1; i >= 0; i--) 
//        {
//            result += words[i] + " " ;
//        }

//        wordsList.Add(result);

//        foreach (String s in wordsList) 
//        {
//            Console.WriteLine("\nReverse Strings: " + s);
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//public class Excercise29
//{
//    public static void Main(string[] args)
//    {
//        FileInfo f = new FileInfo("C:/Users/Mariano/Desktop/abc.txt");
//        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//public class Excercise30
//{
//    public static void Main(string[] args)
//    {
//        string hex = "4B0";
//        Console.WriteLine("Hexadecimal number: " + hex);

//        int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
//        Console.WriteLine("Decimal number: " + dec);

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//public class Excercise31
//{
//    public static void Main(string[] args)
//    {
//        int[] first_array = { 1, 3, -5, 4 };
//        int[] second_array = { 1, 4, -5, -2 };

//        Console.WriteLine("\n |{0}  {1}| \n |{2}  {3}|\n", first_array[0], first_array[1], first_array[2], first_array[3]);
//        Console.WriteLine("\n |{0}  {1}| \n |{2}  {3}|\n", second_array[0], second_array[1], second_array[2], second_array[3]);

//        for (int i = 0; i < first_array.Length; i++) 
//        {
//            Console.Write( first_array[i] * second_array[i] + " ");
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise32
//{
//    public static void Main(string[] args)
//    {
//        string str;

//        Console.Write("Input a string: ");
//        str = Console.ReadLine();

//        if (str.Length > 4)
//        {
//            Console.WriteLine(str.Length < 4 ? str + str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise33
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        if (num1 > 0) {
//            Console.WriteLine(num1 % 3 == 0 || num1 % 7 == 0);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise34
//{
//    public static void Main(string[] args)
//    {
//        string str;

//        Console.Write("Input a string: ");
//        str = Console.ReadLine();

//        Console.WriteLine((str.Length < 7 && str.Equals("Buenas")) || (str.StartsWith("Buenas") && str[6] == ' '));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise35
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine( num1 < 100 && num2 > 200);

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise36
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine((num1 >= - 10 && num1 <= 10)&& (num2 >= -10 && num2 <= 10));

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise37
//{
//    public static void Main(string[] args)
//    {
//        string str = "PHP Tutorial";

//        Console.WriteLine(str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str);

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise38
//{
//    public static void Main(string[] args)
//    {
//        string str = "PHP Tutorial";
//        var res = "";

//        if (str.Length >= 1 && str[0] == 'P') {
//            res += str[0];
//        }

//        if (str.Length >= 2 && str[1] == 'H')
//        {
//            res += str[1];
//        }

//        Console.WriteLine(res);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise39
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        int num3 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Largest of three: " + Math.Max(num1, Math.Max(num2, num3)));
//        Console.WriteLine("Largest of three: " + Math.Min(num1, Math.Min(num2, num3)));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise40
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("\nInput the second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        var res1 = Math.Abs(num1 - 20);
//        var res2 = Math.Abs(num2 - 20);

//        Console.WriteLine(res1==res2 ? 0 : (res1 < res2 ? num1 : num2));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise41
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Input a string: ");
//        string str = Console.ReadLine();

//        var count = str.Count(i => i == 'w');

//        Console.WriteLine(count >= 1 && count <= 3);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise42
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Input a string: ");
//        string str = Console.ReadLine();

//        if (str.Length < 4) {
//            Console.WriteLine(str.ToUpper());
//        }
//        else {
//            Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length-4));
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise43
//{
//    public static void Main(string[] args)
//    { 
//        Console.Write("Input a string: ");
//        string str = Console.ReadLine();

//        Console.WriteLine(test(str));

//    }

//    public static bool test(string str) {
//        var w = 0;

//        for (var i = 0; i < str.Length - 1; i++) {
//            if (str[i].Equals('w')) {
//                w++;
//            }
//            if (str.Substring(i, 2).Equals("ww") && w > 2) {
//                return true;
//            }
//        }

//        return false;
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise44
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Input a string: ");
//        string str = Console.ReadLine();

//        var res = string.Empty;

//        for (var i = 0; i < str.Length; i++) {
//            if (i % 2 == 0)
//            {
//                res += str[i];
//            }
//        }

//        Console.WriteLine(res);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise45
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        int[] nums = { 4, 5, 6, 8, 63, 12, 2, 34, 5, 6, 7, 8, 9 };

//        Console.WriteLine(nums.Count(n => n == num1));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise46
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("\nInput the number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        int[] nums = { 4, 5, 6, 8, 63, 12, 2, 34, 5, 6, 7, 8, 9 };

//        Console.WriteLine((nums[0]==num1)||(nums[nums.Length-1] == num1));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise47
//{
//    public static void Main(string[] args)
//    {
//        var res = 0;

//        int[] nums = { 4, 5, 6, 8, 63, 12, 2, 34, 5, 6, 7, 8, 9 };

//        for (var i = 0; i < nums.Length; i++) {
//            Console.WriteLine("\n{0}", nums[i]);
//            res += nums[i];
//        }

//        Console.WriteLine("\n\nSum: " + res);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise48
//{
//    public static void Main(string[] args)
//    {


//        int[] nums = { 4, 5, 6, 8, 63, 12, 2, 34, 5, 6, 7, 8, 4 };

//        Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length-1])));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise49
//{
//    public static void Main(string[] args)
//    {
//        int[] nums1 = { 4, 5, 6, 8, 63, 12, 2, 34, 5, 6, 7, 8, 4 };
//        int[] nums2 = { 4, 5, 6, 8, 1 };

//        Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length-1])));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise50
//{
//    public static void Main(string[] args)
//    {
//        int[] nums = { 9, 7, 8 };
//        var val = nums[0];

//        for (var i = 0; i < nums.Length - 1; i++)
//        {
//            nums[i] = nums[i + 1];
//        }

//        nums[nums.Length - 1] = val;

//        Console.WriteLine("Rotate array: {0}",string.Join(", ",nums));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise51
//{
//    public static void Main(string[] args)
//    {
//        int[] nums = { 2, 2, 9, 7, 8 };
//        var val = nums[0];

//        for (var i=0;i<nums.Length;i++)
//        {
//            if (nums[i] > nums[0]) {
//                val = nums[i];
//            }
//        }

//        Console.WriteLine("Highest value: {0}", val);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise52
//{
//    public static void Main(string[] args)
//    {
//        int[] nums1 = { 2, 1, 9};
//        int[] nums2 = { 2, 2, 9 };
//        int[] nums3 = { 2, 3, 9 };

//        int[] num4 = { nums1[1], nums2[1], nums3[1] };
//        Console.WriteLine("\nNew array: [{0}]",string.Join(", ",num4));
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise53
//{
//    public static void Main(string[] args)
//    {
//        int[] nums = { 2, 1, 9, 8, 6 };
//        Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
//    }

//    public static bool even_odd(int[] nums)
//    {
//        foreach (var n in nums)
//        {
//            if (n % 2 != 0)
//            {
//                return true;
//            }
//        }
//        return false;
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise54
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(centuryFromYear(1799)==18);
//        Console.WriteLine(centuryFromYear(1900) == 19);
//        Console.WriteLine(centuryFromYear(1901) == 19);
//        Console.WriteLine(centuryFromYear(1901) == 20);
//        Console.WriteLine(centuryFromYear(1806) == 19);
//        Console.WriteLine(centuryFromYear(1568) == 20);
//        Console.WriteLine(centuryFromYear(2010) == 21);
//    }

//    public static int centuryFromYear(int year)
//    {
//        return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise55
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(array_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
//        Console.WriteLine(array_product(new int[] { 0, -1, -1, -2 }) == 2);
//        Console.WriteLine(array_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
//        Console.WriteLine(array_product(new int[] { 1, 4, 3, 0 }) == 16);
//    }

//    public static int array_product(int[] array )
//    {
//        int index = 0;
//        int product = array[index] * array[index + 1];

//        index++;

//        while (index + 1 < array.Length) {
//            product = ((array[index] * array[index + 1]) > product) ? (array[index] * array[index + 1]) : product;
//            index++;
//        }

//        return product;

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise56
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(capicua("aaa"));    
//        Console.WriteLine(capicua("abc"));    
//        Console.WriteLine(capicua("madam"));  
//        Console.WriteLine(capicua("1234"));
//    }

//    public static bool capicua(string inputString)
//    {
//        char[] c = inputString.ToCharArray();

//        Array.Reverse(c);

//        return new string(c).Equals(inputString);

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise57
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(array_product(new int[] { 2, 4, 2, 6, 9, 3 }));
//        Console.WriteLine(array_product(new int[] { 0, -1, -1, -2 }));
//        Console.WriteLine(array_product(new int[] { 6, 1, 12, 3, 1, 4 }));
//        Console.WriteLine(array_product(new int[] { 1, 4, 3, 0 }));
//    }

//    public static int array_product(int[] array)
//    {
//        int max = array[0] * array[1];

//        for (int i = 1; i <= array.Length-2; i++) {
//            max = Math.Max(max, array[i] * array[i + 1]);
//        }

//        return max;
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise58
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(consecutive(new int[] { 1, 3, 5, 6, 9 })); 
//        Console.WriteLine(consecutive(new int[] { 0, 10 })); 
//    }

//    public static int consecutive(int[] array)
//    {
//        Array.Sort(array);

//        int missings_nums = 0;

//        for (int i = 0; i < array.Length - 1; i++) {
//            missings_nums += array[i + 1] - array[i] - 1;
//        }

//        return missings_nums;
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise59
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));
//        Console.WriteLine(Increasing_Sequence(new int[] { 0, 10 }));
//        Console.WriteLine(Increasing_Sequence(new int[] { 1, 3, 1, 3 }));
//    }

//    public static bool Increasing_Sequence(int[] array)
//    {
//        int n = 0;

//        for (int i = 0; i < array.Length - 1; i++) {
//            if (array[i] >= array[i + 1]) {
//                n++;
//            }
//            if (i + 2 < array.Length && array[i] >= array[i + 2]) {
//                n++;
//            }
//        }
//        return n <= 2;
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//public class Excercise60
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(sum_matrix_elements(
//            new int[][] {
//                new int[]{0, 2, 3, 2},
//                new int[]{0, 6, 0, 1},
//                new int[]{4, 0, 3, 0}
//            }));

//        Console.WriteLine(sum_matrix_elements(
//             new int[][] {
//                new int[]{1, 2, 1, 0 },
//                new int[]{0, 5, 0, 0},
//                new int[]{1, 1, 3, 10 }
//             }));

//        Console.WriteLine(sum_matrix_elements(
//            new int[][] {
//                new int[]{1, 1},
//                new int[]{2, 2},
//                new int[]{3, 3},
//                new int[]{4, 4}
//            }));
//    }

//    public static int sum_matrix_elements(int[][] matrix)
//    {
//        int sum = 0;

//        for (int i = 0; i < matrix[0].Length; i++) {
//            for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++) {
//                sum += matrix[j][i];
//            }
//        }

//        return sum;
//    }
//}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public class Excercise61
{
    public static void Main(string[] args)
    {
        Console.WriteLine(reverse_parentheses("p(rq)st"));       
        Console.WriteLine(reverse_parentheses("(p(rq)st)"));     
        Console.WriteLine(reverse_parentheses("ab(cd(ef)gh)ij"));
    }

    public static string reverse_parentheses(string str)
    {
        
    }
}