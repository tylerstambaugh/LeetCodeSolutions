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

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {            
            int nums1Index = 0, nums2Index = 0; 

            if(m == 0 && n == 1)
            {
                nums1[0] = nums2[0];
            }

            if(m == 1 && n == 1)
            {
                if (nums1[0] > nums2[0])
                {
                    nums1[1] = nums1[0];
                    nums1[0] = nums2[0];
                }
                else
                {
                    nums1[1] = nums2[0];
                }
                return;
            }

            if (n > 0)
            {

                while (nums1Index < nums1.Length && nums2Index < n)
                {
                    if (nums1[nums1Index] > nums2[nums2Index] || nums1[nums1Index] == 0)
                    {
                        //shift remaining values of nums1 to the right
                        for (int i = nums1.Length - 1; i >= nums1Index + 1; i--)
                        {
                            nums1[i] = nums1[i - 1];
                        }

                        //swap value from nums2 into place of nums1 index
                        nums1[nums1Index] = nums2[nums2Index];

                        nums1Index++;
                        nums2Index++;
                    }
                    else
                    {
                        nums1Index++;
                    }
                }
            }
        }    
    }
}
