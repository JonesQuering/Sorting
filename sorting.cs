using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class sorting
    {
        static void Main(string[] args)
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));


            string[] stringValues = { "Bob", "Jenkins", "Dylan", "Michael", "James", "Marie", "Anne", "Nicole" };
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.ReadLine();
        }
    }
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);

            }
        }
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap<T>(T[] array, int first, int second) where T : IComparable
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;

        }
    }
    public static class BubbleSort
    {
        //public static void Sort<T>(T[] array) where T : IComparable
        //{
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        for(int j = 0; j < array.Length - 1; j++)
        //        {
        //            if (array[j].CompareTo(array[j + 1]) > 0)
        //            {
        //                Swap(array, j, j + 1);
        //            }
        //        }
        //    }
        //}
        //modified so if no changes are necessary 
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }
                if (!isAnyChange)
                {
                    break;
                }
            }
            return array;
        }
        private static void Swap<T>(T[] array, int first, int second) where T : IComparable
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;

        }
    }
    public static class QuickSort
    {
        public static void Sort<T> (T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }
        public static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            // or: T pivot = array[(lower + upper) / 2];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i <= j) { break; }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }
        private static void Swap<T>(T[] array, int first, int second) where T : IComparable
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;

        }
    }
}
