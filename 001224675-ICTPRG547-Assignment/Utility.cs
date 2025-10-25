using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    public class Utility
    {
        /// <summary>
        /// FOR EACH index in array
        ///     IF array[index] EQUALS target THEN
        ///     RETURN index
        /// END FOR
        /// RETURN -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>the index of the found object</returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(target))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// CREATE min = 0
        /// CREATE max = length of array - 1
        /// WHILE min <= max DO
        ///     SET mid = min + (max - min) / 2
        ///     SET comparison = array[mid] COMPARETO target
        ///     IF comparison EQUALS 0 THEN
        ///         RETURN mid
        ///     ElSE IF comparison < 0 THEN
        ///         SET min = mid + 1
        ///     ELSE
        ///         MAX = mid - 1
        ///     END IF
        /// END WHILE
        /// RETURN -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>the index of the found object</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            if(!IsSorted(array))
            {
                throw new ArgumentException("Array must be sorted for binary search", nameof(array));
            }

            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = min + (max - min) /2;
                int comparison = target.CompareTo(array[mid]);
                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison > 0)
                {
                    min = mid + 1; 
                }
                else
                {
                    max = mid - 1; 
                }
            }
            return -1; 
        }

        /// <summary>
        /// DECLARE length = length of array - 1
        /// FOR j FROM 0 TO length DO
        ///     FOR i FROM 0 TO length DO
        ///         IF array[i] > array[i + 1] THEN
        ///             SET temp = array[i]
        ///             SET array[i] = array[i + 1]
        ///             SET array[i + 1] = temp
        ///     END FOR
        /// END FOR
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void BubbleSortOfArrayInAscending<T>(T[] array) where T : IComparable<T>
        {
            int length = array.Length-1;
            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// DECLARE length = length of array - 1
        /// FOR j FROM 0 TO length DO
        ///     FOR i FROM 0 TO length DO
        ///         IF array[i] < array[i + 1] THEN
        ///             SET temp = array[i]
        ///             SET array[i] = array[i + 1]
        ///             SET array[i + 1] = temp
        ///     END FOR
        /// END FOR
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void BubbleSortOfArrayInDescending<T>(T[] array) where T : IComparable<T>
        {
            int length = array.Length - 1;
            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        private static bool IsSorted<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
