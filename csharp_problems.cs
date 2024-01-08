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
/*4.Roman to Integer-Convert a Roman numeral to an integer. Input is guaranteed to be within the range from 1 to 3999.
public int RomanToInt(string s) {
    Dictionary<char, int> romanDict = new Dictionary<char, int> {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    int result = 0;
    int prevValue = 0;
    
    for (int i = s.Length - 1; i >= 0; i--) {
        int value = romanDict[s[i]];
        result += (value >= prevValue) ? value : -value;
        prevValue = value;
    }
    
    return result;
}
*/