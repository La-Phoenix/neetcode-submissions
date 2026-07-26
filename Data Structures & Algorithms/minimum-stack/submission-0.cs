public class MinStack {
    Stack<int> mainStack;
    Stack<int> minsStack;
    public MinStack() {
        mainStack = new();
        minsStack = new();
    }
    
    public void Push(int val) {
        if (mainStack.Count == 0){
            minsStack.Push(val);
        } else {
            int top = minsStack.Peek();
            if(val <= top){
                minsStack.Push(val);
            } else {
                minsStack.Push(top);
            }
        }
        mainStack.Push(val);
    }
    
    public void Pop() {
        mainStack.Pop();
        minsStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek(); 
    }
    
    public int GetMin() {
        return minsStack.Peek();
    }
}
