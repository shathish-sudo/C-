/* Longest Common Prefix
=======================================
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.
*/

public string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
    {
        return "";
    }

    string commonPrefix = strs[0]; // Initialize with the first string

    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(commonPrefix) != 0)
        {
            commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);

            if (commonPrefix.Length == 0)
            {
                return "";
            }
        }
    }

    return commonPrefix;
}
