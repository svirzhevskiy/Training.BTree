namespace Training.BTree;

public class Node
{
    public Node(int[] keys, Node[] children)
    {
        Keys = keys;
        Children = children;
    }

    private int[] Keys { get; set; }
    private Node[]? Children { get; set; }

    private bool IsLeaf => Children is null || Children.Length == 0;

    public Node FindNode(int searchKey)
    {
        if (IsLeaf)
        {
            return this;
        }
        
        var keyIndex = 0;
        while (searchKey > Keys[keyIndex])
        {
            keyIndex++;

            if (keyIndex == Keys.Length)
            {
                break;
            }
        }

        return Children![keyIndex].FindNode(searchKey);
    }

    public string WriteKeys()
    {
        return string.Join(",", Keys);
    }
}