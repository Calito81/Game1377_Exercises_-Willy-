using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchExample();
            ArraysAndLoopsExamples();
            MethodA();
            float[] floatArray = { 1.1f, 2.2f, 3.3f };
            double[] doubleArray = { 4.444d, 5.555d, 6.666d };
            MethodB(floatArray);
            MethodB(doubleArray);
            int[] intArray = { 5, 6, 9 };
            MethodC(intArray);
            MethodD(floatArray);
            MethodD(doubleArray);            
        }

        static void SwitchExample()
        {
            Console.WriteLine("Input a WASD key");

            string? inputs = Console.ReadLine();
            switch (inputs)
            {
                case "w":
                    Console.WriteLine("You moved up");
                    break;
                case "s":
                    Console.WriteLine("You moved down");
                    break;
                case "a":
                    Console.WriteLine("You moved left");
                    break;
                case "d":
                    Console.WriteLine("You moved right");
                    break;
            }
        }

        static void ArraysAndLoopsExamples()
        {
            int[] values = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };

            Console.WriteLine("\nArray Backwards-");

            for (int i = values.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("\nPlayer, please input random number from -783 to 179");

            bool arrayValues = true;

            while (arrayValues)
            {
                int numbers = Convert.ToInt32(Console.ReadLine());

                foreach (int i in values)
                {
                    if (i == numbers)
                    {
                        arrayValues = false;
                    }
                }
            }

            Console.WriteLine("\nArray Average-");

            int adding = 0;

            for (int i = 0; i < values.Length; i++)
            {
                adding += values[i];
            }
            int average = adding / values.Length;
            Console.WriteLine(average);

            Console.WriteLine("\nEvery other number-");

            for (int i = 0; i < values.Length; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("\nEvery third number-");

            for (int i = 0; i < values.Length; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("\nEnter array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter range minimum");
            int rangeMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter range maximum");
            int rangeMax = Convert.ToInt32(Console.ReadLine());

            int[] dynamic = new int[arraySize];

            Random rnd = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                dynamic[i] = rnd.Next(rangeMin, rangeMax);
            }
        }

        static void MethodA()
        {
            int[] arrayA = { 1, 2, 3, 4 };
            Console.WriteLine("\nAll array elements");
            
            foreach (int i in arrayA)
            {
                Console.WriteLine(i);
            }
        }

        static void MethodB(float[] var)
        {
            Console.WriteLine("\nAll float array elements");

            foreach(float i in var)
            {
                Console.WriteLine(i);
            }
        }

        static void MethodB(double[] var)
        {
            Console.WriteLine("\nAll double array elements");

            foreach(double i in var)
            {
                Console.WriteLine(i);
            }
        }

        static void MethodC(int[] var)
        {
            Console.WriteLine("\nFloat average");
            
            int adding = 0;

            for (int i = 0; i < var.Length; i++)
            {
                adding += var[i];
            }
            float average = (float)adding / var.Length;
            Console.WriteLine(average);
        }

        static void MethodD(float[] var)
        {
            Console.WriteLine("\nFloat average using method D");

            float adding = 0;

            for (int i = 0; i < var.Length; i++)
            {
                adding += var[i];
            }
            float average = adding / var.Length;
            Console.WriteLine(average);
        }

        static void MethodD(double[] var)
        {
            Console.WriteLine("\nDouble average");

            double adding = 0;

            for (int i = 0; i < var.Length; i++)
            {
                adding += var[i];
            }
            double average = adding / var.Length;
            Console.WriteLine(average);
        }
    }
}