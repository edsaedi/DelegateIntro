using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateIntro
{
    internal class Program
    {
        private delegate int Math(int x, int y);

        private static void DoMath(int a, int b, Math math)
        {
            int answer = math(a, b);
            Console.WriteLine($"[ {a}, {b} ] = {answer}");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        //static int Subtract(int x, int y)
        //{
        //    return x - y;
        //}

        //static int Derp(int x, char b)
        //{
        //    return 1;
        //}


        private static void MyFunction()
        {

            void MiniFunction() //nested functions; only available to parent (MyFunction)
            {

            }
        }

        private delegate int CompareNum(int a, int b);

        private static int[] BubbleSort(int[] array, CompareNum comp)
        {
            bool swap;
            do
            {
                swap = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (comp(array[i - 1], array[i]) > 0)
                    {
                        swap = true;
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }
            } while (swap);

            return array;
        }

        private static void Main(string[] args)
        {

            string word = "Hello";

            word.Reverse();
            Extensions.Reverse(word);

            List<int> numbers = new List<int>();
            numbers.RemoveAll((int a) => a % 2 == 1);

            Random rand = new Random(42);
            int[] randos = new int[20];
            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = rand.Next(1, 100);
            }

            randos = BubbleSort(randos, (int a, int b) => a.CompareTo(b));

            Console.Write("[ ");
            for (int i = 0; i < randos.Length; i++)
            {
                Console.Write($"{randos[i]} ");
            }
            Console.WriteLine("]");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Math add = (int x, int y) => x + y;
            //Math sub = (int x, int y) => x - y;
            //Math div = (int x, int y) => x / y;
            //Math mul = (int x, int y) => x * y;
            //DoMath(a, b, add);

            Console.ReadKey();
        }
    }

    public static class Extensions
    { 
        /// <summary>
        /// The summary of the function
        /// </summary>
        /// <param name="source">info on param</param>
        /// <returns>info on returns</returns>
        public static string Reverse(this string source)
        {
            //using stirng builder because more efficient
            StringBuilder build = new StringBuilder();
            for (int i = source.Length-1; i >= 0; i--)
            {
                build.Append(source[i]);
            }
            return build.ToString();
        }
    }

}
