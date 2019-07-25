using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    //https://www.youtube.com/watch?v=QZOLb0xHB_Q&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=18
    public class BalanceParentheses
    {
        Stack<string> myStack = new Stack<string>();

        //things to check
        // if we have opening parenth then it should have closing one in stack. or push or pop it as per your stack
        //if we have opening as first char then push it; '('
        // if we have closing one check in stack if we have last push was corresponding to it then remove it from stack else return false.
        // if we have first as closing prenth then return false. ')'

        //expressions to check
        // )(  =false  
        // [()]= ture
        //[(]) = false
        //[()()]  = true
        BalanceParentheses()
        {

        }
        public bool CheckBalancedParentheses(string expression)
        {
            char[] exp = StringToArray(expression);

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '[' || exp[i] == '(')
                {
                    myStack.Push(exp[i].ToString());
                }
                else if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (myStack.Count == 0 || myStack.Peek() != exp[i].ToString())
                    {
                        return false;
                    }
                    else
                    {
                        myStack.Pop();
                    }
                }
            }
            return myStack.Count == 0 ? true : false;
        }

        public char[] StringToArray(string expression)
        {
            return expression.ToCharArray();
        }
    }
}
