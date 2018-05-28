using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class QuicSort
    {
        public static void quickSort(ref int[] array)
        {
            quickSort(array, 0, array.Length - 1);

        }
        public static void quickSort(int[] array, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];
            int index = partition(array, left, right, pivot);
            quickSort(array, left, index - 1);
            quickSort(array, index, right);

        }

        private static int partition(int[] array, int left, int right, int pivot)
        {
            while(left<= right) {
                while(array[left] < pivot)
                {
                    left++;
                }

                while(array[right]> pivot)
                {
                    right--;
                }
                if(left <= right)
                {
                    swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        static void swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
