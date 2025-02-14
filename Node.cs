namespace Training.BTree;

public class Node
{
    public Node(int[] keys, Node[] children)
    {
        Keys = keys;
        Children = children;
    }

    public int[] Keys { get; set; }
    public Node[]? Children { get; set; }

    public bool IsLeaf => Children is null || Children.Length == 0;

    public int Find(int searchKey)
    {
        if (IsLeaf)
        {
            return Array.Find(Keys, key => key == searchKey);
        }
        
        var keyIndex = 0;
        while (searchKey > Keys[keyIndex])
        {
            keyIndex++;
        }

        return Children![keyIndex].Find(searchKey);
    }
}