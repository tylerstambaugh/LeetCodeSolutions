namespace LeetCodeSolutions
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {           
            int leftCounter = 0, rightCounter = 0;

            if (nums2.Length > 0)
            {
                for (int i = 1; i <= nums1.Length; i++)
                {
                    Console.WriteLine($"iteration = {i}");
                    if (nums1[leftCounter] != 0 && nums1[leftCounter] <= nums2[rightCounter])
                    {
                        Console.WriteLine($"nums1[{leftCounter}] = {nums1[leftCounter]}");
                        Console.WriteLine($"nums2[{rightCounter}] = {nums2[rightCounter]}");
                        Console.WriteLine("nothing changes, incrementing left counter");
                        leftCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"nums1[{leftCounter}] = {nums1[leftCounter]}");
                        Console.WriteLine($"nums2[{rightCounter}] = {nums2[rightCounter]}");
                        Console.WriteLine("Right side is smaller, taking value at right array and putting it back into sorted array. Incrementing both counters.");
                        if (leftCounter < nums1.Length - 1)
                        {
                            nums1[leftCounter + 1] = nums1[leftCounter];
                        }
                        nums1[leftCounter] = nums2[rightCounter];
                        rightCounter++;
                        leftCounter++;
                    }
                }
            }
        }
    }
}
