/*1.Two Sum -Given an array of numbers, find the two numbers such that they add up to a specific target.
public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> numIndices = new Dictionary<int, int>();
    
    for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (numIndices.ContainsKey(complement)) {
            return new int[] { numIndices[complement], i };
        }
        numIndices[nums[i]] = i;
    }
    
    return new int[] { -1, -1 }; // Eğer çözüm bulunamazsa
}
*/
/*2.Reverse Integer-Reverse an integer. For example, reverse 123 to get 321.
public int Reverse(int x) {
    int sign = x >= 0 ? 1 : -1;
    x = Math.Abs(x);
    
    long reversedX = 0;
    while (x > 0) {
        reversedX = reversedX * 10 + x % 10;
        x /= 10;
    }
    
    reversedX *= sign;
    return (reversedX >= int.MinValue && reversedX <= int.MaxValue) ? (int)reversedX : 0;
}
*/
/*3.Palindrome Number-Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
public bool IsPalindrome(int x) {
    if (x < 0) {
        return false;
    }
    string strX = x.ToString();
    int left = 0, right = strX.Length - 1;
    
    while (left < right) {
        if (strX[left] != strX[right]) {
            return false;
        }
        left++;
        right--;
    }
    
    return true;
}
*/