public class Solution {
    public bool IsValid(string s) {
        Stack<char> myStack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                myStack.Push(c);
            }
            else if (c == '}' && (myStack.Count != 0) && myStack.Peek() == '{')
            {
                myStack.Pop();
            }
            else if (c == ']' && (myStack.Count != 0) && myStack.Peek() == '[')
            {
                myStack.Pop();
            }
                     
            else if (c == ')' && (myStack.Count != 0) && myStack.Peek() == '(')
            {
                myStack.Pop();
            }
            else
            {
                return false;
            }
        }
        if (myStack.Count == 0)
        {
            return true;
        }
        else
            return false;
    }
}
