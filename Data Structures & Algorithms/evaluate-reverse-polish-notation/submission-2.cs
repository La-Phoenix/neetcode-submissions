public class Solution {
    public int EvalRPN(string[] tokens) {
        Dictionary<string, Func<int, int, int>> ops = new () {
            {"+", (a, b) => a + b},
            {"-", (a, b) => a - b},
            {"*", (a, b) => a * b},
            // Skip division by 0 check since exp is given to be valid
            {"/", (a, b) => a / b}
        };
        Stack<int> nums = new();

        // Arr is given to be a valid arithmetic expression 
        //in Reverse Polish Notation.
        foreach(string token in tokens){
            if(int.TryParse(token, out int num)){
                nums.Push(num);
            } else {
                int num1 = nums.Pop();
                int num2 = nums.Pop();
                if (ops.ContainsKey(token)){
                    nums.Push(ops[token](num2, num1));
                }
            }
        }

        return nums.Peek();
    }
}
