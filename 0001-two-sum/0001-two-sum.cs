public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        int tmp = 0;
        int rest = 0;
        int[] res = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            tmp = nums[i];
            rest = target - tmp;

            if (hashMap.ContainsKey(rest)) {
                res[0] = i;
                res[1] = hashMap[rest];
                return res;
            }

            hashMap[tmp] = i;
        }

        return new int[0];
    }
}