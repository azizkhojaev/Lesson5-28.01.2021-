using System;

namespace Lesson5
{
    static class ArrayHelper
    {

        public static string Pop( ref string[] V)
        {
            string Temp=""; 
            if (V.Length!=0)
            {
                Temp= V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
            }
            else
                Console.WriteLine("Array is empty " );

            return Temp;
            
        }
        public static int  Pop(ref int[] V)
        {
            int Temp=0 ;
            if (V.Length != 0)
            {
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
            }
            else
                Console.WriteLine("Array is empty ");

            return Temp;
        }
        public static double Pop(ref double[] V)
        {
            double Temp = 0;
            if (V.Length != 0)
            {
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
            }
            else
                Console.WriteLine("Array is empty ");

            return Temp;
        }
        public static decimal Pop(ref decimal[] V)
        {
            decimal Temp = 0;
            if (V.Length != 0)
            {
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
            }
            else
                Console.WriteLine("Array is empty ");

            return Temp;
        }
        public static float Pop(ref float[] V)
        {
            float Temp = 0;
            if (V.Length != 0)
            {
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
            }
            else
                Console.WriteLine("Array is empty ");

            return Temp;
        }


        public static int Push(ref string[] V, string x)
        {
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            return V.Length;
        }
        public static int Push(ref int[] V, int x)
        {

            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            return V.Length;
        }
        public static int Push(ref double[] V, double x)
        {

            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            return V.Length;
        }
        public static int Push(ref decimal[] V, decimal x)
        {

            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            return V.Length;
        }
        public static int Push(ref float[] V, float x)
        {

            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            return V.Length;
        }
        public static string Shift(ref string[] V)
        {
            string Temp = "";
            if (V.Length!=0)
            {
                Array.Reverse(V);
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
                Array.Reverse(V);
            }
            else
                Console.WriteLine("Array is empty");

            return Temp;
        }
        public static int Shift(ref int[] V )
        {

            int Temp=0;
            if (V.Length != 0)
            {
                Array.Reverse(V);
                Temp= V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
                Array.Reverse(V);
            }
            else
                Console.WriteLine("Array is empty");

            return Temp;
        }
        public static double Shift(ref double[] V)
        {
            double Temp = 0;
            if (V.Length != 0)
            {
                Array.Reverse(V);
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
                Array.Reverse(V);
            }
            else
                Console.WriteLine("Array is empty");

            return Temp;
        }
        public static decimal Shift(ref decimal[] V)
        {
            decimal Temp = 0;
            if (V.Length != 0)
            {
                Array.Reverse(V);
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
                Array.Reverse(V);
            }
            else
                Console.WriteLine("Array is empty");

            return Temp;
        }
        public static float Shift(ref float[] V)
        {
            float Temp = 0;
            if (V.Length != 0)
            {
                Array.Reverse(V);
                Temp = V[V.Length - 1];
                Array.Resize(ref V, V.Length - 1);
                Array.Reverse(V);
            }
            else
                Console.WriteLine("Array is empty");

            return Temp;
        }
        public static int UnShift(ref string[] V, string x)
        {
            Array.Reverse(V);
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            Array.Reverse(V);
            return V.Length;
        }
        public static int UnShift(ref int[] V, int x)
        {

            Array.Reverse(V);
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            Array.Reverse(V);
            return V.Length;
        }
        public static int UnShift(ref double[] V, double x)
        {

            Array.Reverse(V);
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            Array.Reverse(V);
            return V.Length;
        }
        public static int UnShift(ref decimal[] V, decimal x)
        {

            Array.Reverse(V);
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            Array.Reverse(V);
            return V.Length;
        }
        public static int UnShift(ref float[] V, float x)
        {

            Array.Reverse(V);
            Array.Resize(ref V, V.Length + 1);
            V[V.Length - 1] = x;
            Array.Reverse(V);
            return V.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] V1 = { "aa", "bb", "cc", "dd" };
            int[] V2 = { 1, 2, 3, 4,5 };
            double[] V3 = { 1.0, 2, 1.5, 2.1 };
            decimal[] V4 = { 5.6m, 6.7m, 7.8m, 8.9m };
            float[] V5 = { 10.1f, 11.2f, 12.3f, 13.4f };


            Console.WriteLine(ArrayHelper.Pop(ref V1));
            Console.WriteLine();
            Console.WriteLine(ArrayHelper.Push(ref V2, 5));
            Console.WriteLine();
            Console.WriteLine(ArrayHelper.Shift(ref V3));
            Console.WriteLine();
            Console.WriteLine(ArrayHelper.UnShift(ref V5, 13f)); 
                       
        }
    }
}
