public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var mergedArray = nums1.Concat(nums2).OrderBy(n => n).ToList();

        int middleIndex = mergedArray.Count / 2;

        return mergedArray.Count % 2 == 0
            ? (mergedArray[middleIndex - 1] + mergedArray[middleIndex]) / 2.0
            : mergedArray[middleIndex];
    }
}