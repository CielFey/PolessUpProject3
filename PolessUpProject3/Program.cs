using System;
using System.Linq;

namespace PolessUpProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5};
            int target = 3;
            int ind = 0;
            bool check = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    ind = i;
                    check = true;
                }
            }
            if (!check)
            {
                for (int i = 0;i < nums.Length; i++)
                {
                    if (target > nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        ind = i - 1;
                    }
                }
            }
            Console.WriteLine("Индекс: {0}",ind);
        }
    }
}
