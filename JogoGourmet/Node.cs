public class Node
{
    public bool IsLeaf;

    public string Text;

    public Node LeftNode;

    public Node RightNode;

    public Node Parent;

    public Node(string value, bool isLeaf)
    {
        Text = value;
        IsLeaf = isLeaf;
        LeftNode = null;
        RightNode = null;
    }

    public Node(string value, bool isLeaf, Node parent)
    {
        Text = value;
        IsLeaf = isLeaf;
        LeftNode = null;
        RightNode = null;
        Parent = parent;
    }
}
