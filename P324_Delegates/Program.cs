using System;
using System.Collections.Generic;
using System.Linq;

namespace P324_Delegates
{
    class Program
    {
        public delegate bool Callback(int num);
        public delegate void CustomConcat(string word, string word2);
        public delegate void Convert(double azn);
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 10, 20, 24, 28, 30, 33, 39, 45 };
            //Console.WriteLine("Sum even numbers");
            //Console.WriteLine(SumEven(arr));
            //Console.WriteLine("Sum odd number");
            //Console.WriteLine(SumOdd(arr));
            //Console.WriteLine("Sum divided by 5 numbers");
            //Console.WriteLine(SumDividedBy5(arr));
            //Console.WriteLine("Sum divided by 7 numbers");
            //Console.WriteLine(SumDividedBy7(arr));

            //Console.WriteLine("\n Delegates");
            //Console.WriteLine("Sum even numbers");
            //Console.WriteLine(Sum(arr,IsEven));
            //Console.WriteLine("Sum odd numbers");
            //Console.WriteLine(Sum(arr, IsOdd));
            //Console.WriteLine("Sum 5");
            //Console.WriteLine(Sum(arr, IsDividedBy5));
            //Console.WriteLine("Sum 7");
            //Console.WriteLine(Sum(arr, IsDividedBy7));


            CustomConcat customConcat = new CustomConcat(Fullname);
            //customConcat("Ismayil", "Ibrahimli");
            //customConcat.Invoke("Ismayil", "Ibrahimli");


            //CustomConcat customConcat1 = Abbreviation;

            //customConcat += customConcat1;
            //customConcat("Ismayil", "Ibrahimli");

            //customConcat1("Chingiz", "Rahimov");

            //Convert convertToDollar = new Convert(ConvertToDollar);
            //Convert convertToEuro = new Convert(ConvertToEuro);
            //Convert convertToLira = new Convert(ConvertToLira);
            //Convert convert = convertToDollar;
            //convert += convertToEuro;
            //convert += convertToLira;
            //convertToDollar(120.76);
            //convertToEuro(120.76);
            //convertToLira(120.76);

            //convert(120.76);

            //convert -= convertToLira;
            //Console.WriteLine("After minus");
            //convert(120.76);


            //Convert convertoToRub = delegate (double azn)
            //{
            //    double price = azn * 30;
            //    Console.WriteLine(price);
            //};

            //Convert convertToLari = azn =>
            //{
            //    double price = azn * 2;
            //    Console.WriteLine(price);
            //};


            //convertoToRub(200);
            //convertToLari(200);

            //Action<string> action = delegate (string word)
            //{
            //    Console.WriteLine(word);
            //};
            //action.Invoke("Hello");

            //Action<int, int> action1 = (num1, num2) =>
            //{
            //    Console.WriteLine(num1+num2);
            //};

            //action1(5, 10);

            //Func<string,int,int> func = (string word,int num) =>
            //{
            //    //Console.WriteLine(5);
            //    return num;
            //};
            //Func<string, int, int> func1 = (word, num) =>
            //{
            //    //Console.WriteLine(10);

            //    return num +5;
            //};

            //Func<string, int, int> result = func;
            //result += func1;
            //Console.WriteLine(result("as", 25));


            Predicate<int> predicate = num => num % 2 == 0 && num > 20;

            //Predicate<string> isUpper = word => { 
            //    return word.Equals(word.ToUpper()) && word.Contains("J");
            //};

            //Console.WriteLine(isUpper("JAMAL"));

            //Console.WriteLine(predicate(10));

            List<int> list = new List<int>(10);
            list.Add(1);
            list.Add(10);
            list.Add(120);
            list.Add(30);

            List<int> newList =  list.Where(x => x >= 30 && x % 10 == 0).ToList();

            int num1 = list.FirstOrDefault(x => x == 39123);
            Console.WriteLine(num1);

            foreach (int num in newList)
            {
                Console.WriteLine(num);
            }

        }

        public static int Sum(int[] arr, Callback func)
        {
            int total = default;
            foreach (int num in arr)
            {
                if (func(num))
                {
                    total += num;
                }
            }
            return total;
        }

        public static int SumEven(int[] arr)
        {
            int total = default;
            foreach (int num in arr)
            {
                if(IsEven(num))
                {
                    total += num;
                }
            }
            return total;
        }

        public static int SumOdd(int[] arr)
        {
            int total = default;
            foreach (int num in arr)
            {
                if (!IsEven(num))
                {
                    total += num;
                }
            }
            return total;
        }
        public static int SumDividedBy5(int[] arr)
        {
            int total = default;
            foreach (int num in arr)
            {
                if (IsDividedBy5(num))
                {
                    total += num;
                }
            }
            return total;
        }
        public static int SumDividedBy7(int[] arr)
        {
            int total = default;
            foreach (int num in arr)
            {
                if (IsDividedBy7(num))
                {
                    total += num;
                }
            }
            return total;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool IsDividedBy5(int num)
        {
            return num % 5 == 0;
        }
        public static bool IsDividedBy7(int num)
        {
            return num % 7 == 0;
        }
       
        public static void Fullname(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }

        public static void Abbreviation(string name, string surname)
        {
            Console.WriteLine($"{char.ToUpper(name[0])}.{char.ToUpper(surname[0])}");
        }

        public static void ConvertToDollar(double azn)
        {
            double price = Math.Round(azn / 1.7,2);
            Console.WriteLine(price + " Dollar");
        }

        public static void ConvertToEuro(double azn)
        {
            double price = Math.Round(azn / 2, 2);
            Console.WriteLine(price + " Euro");
        }
        public static void ConvertToLira(double azn)
        {
            double price = Math.Round(azn * 11, 2);
            Console.WriteLine(price + " TL");
        }
    }
}
