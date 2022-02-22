using System;

namespace Day13_Generics
{
    class Program
    {
        public static void print<A>(A[] a)
        {
            foreach(A value in a)
            {
                Console.WriteLine(value);
            }
        } 




        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MaxInt findmaxint = new MaxInt();
            //Console.WriteLine("Maximum Value Between Three Int Is : " + findmaxint.FindMaxValue(20,30,50));
            
            int output = MaxInt.FindMaxValue(20, 13, 52);
            Console.WriteLine("Maximum Value Between Three Int Is " + output);

            //int output1 = MaxInt.FindMaxValue(1.2, 5.2, 3.2);
            //Console.WriteLine("Maximum Value Between Three Int Is " + output1);


            double output1 = MaxFloat.FindMaxValue1(2.1, 2.2, 1.3);
            Console.WriteLine("Maximum Value Between Three Float Is " + output1);



            string strigoutput = MaxString.MaximumStringNumber("apple", "mango", "grapes");
            Console.WriteLine("Maximum Value Between Three Float Is "+ strigoutput);


            int[] intArray = { 11, 3442, 4032, 55, 68 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 1.2, 340.4, 44.36, 51.55, 67.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();




        }
    }
}
