using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 9,14,13, 5, 7, 6, 8, 10, 11, 12, 0, 4, 3, 2,15 };
            int[] outputAsc = BubleSort(input,true);
            Console.WriteLine("Ascending");
            foreach(int i in outputAsc)
            {
                Console.Write("{0} ", i);
            }

            int[] outputDesc = BubleSort(input, false);
            Console.WriteLine(System.Environment.NewLine + "Descending");
            foreach (int i in outputDesc)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }

        static int[] BubleSort(int[] nums,bool asc)
        {
            int temp = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    if (asc == true)
                    {
                        if (nums[x] < nums[y])
                        {
                            temp = nums[x];
                            nums[x] = nums[y];
                            nums[y] = temp;
                        }
                    }else
                    {
                        if (nums[x] > nums[y])
                        {
                            temp = nums[x];
                            nums[x] = nums[y];
                            nums[y] = temp;
                        }
                    }
                }
            }

            return nums;
        }
    }
}
