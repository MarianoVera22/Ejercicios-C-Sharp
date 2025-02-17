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

using System;
using System.Collections.Generic;
using System.IO;
public class Excercise31
{
    public static void Main(string[] args)
    {
        int[] first_array = { 1, 3, -5, 4 };
        int[] second_array = { 1, 4, -5, -2 };

        Console.WriteLine("\n |{0}  {1}| \n |{2}  {3}|\n", first_array[0], first_array[1], first_array[2], first_array[3]);
        Console.WriteLine("\n |{0}  {1}| \n |{2}  {3}|\n", second_array[0], second_array[1], second_array[2], second_array[3]);

        for (int i = 0; i < first_array.Length; i++) 
        {
            Console.Write( first_array[i] * second_array[i] + " ");
        }

    }
}