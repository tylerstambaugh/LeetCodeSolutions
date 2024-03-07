namespace LeetCodeSolutions
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (nums1[i] > nums2[i])
                {
                    nums1[i] = nums2[i];
                }
            }
        }
    }
}
