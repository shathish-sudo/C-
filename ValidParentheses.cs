/*  Valid Parentheses

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/

public bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> mapping = new Dictionary<char, char>
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

    foreach (char c in s)
    {
        if (mapping.ContainsKey(c))
        {
            char topElement = stack.Count > 0 ? stack.Pop() : '#';
            if (topElement != mapping[c])
            {
                return false;
            }
        }
        else
        {
            stack.Push(c);
        }
    }

    return stack.Count == 0;
}
