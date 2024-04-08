public class Tree
{
    public Node Root;
    public Node Current;

    public Tree(Node root)
    {
        Root = root;
        Current = root;
    }

    public void Next(bool answer)
    {
        if (answer)
            Current = Current.RightNode;
        else
            Current = Current.LeftNode;
    }

    public void Reset ()
    {
        Current = Root;
    }
}