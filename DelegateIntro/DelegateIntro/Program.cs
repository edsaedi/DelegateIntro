using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntro
{
    class Program
    {
        delegate int Math(int x, int y);

        static void DoMath(int a, int b, Math math)
        {
            int answer = math(a, b);
            Console.WriteLine($"[ {a}, {b} ] = {answer}");
        }


        static int Add(int x, int y)
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


        static void MyFunction()
        {

            void MiniFunction() //nested functions; only available to parent (MyFunction)
            {

            }
        }


        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Math add = (int x, int y) => x + y;
            Math sub = (int x, int y) => x - y;
            Math div = (int x, int y) => x / y;
            Math mul = (int x, int y) => x * y;


            DoMath(a, b, add);

            Console.ReadKey();
        }
    }
}
