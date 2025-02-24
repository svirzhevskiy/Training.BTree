using Training.BTree;

var root = new Node([10, 20, 30], [
    new Node([5], [
        new Node([3, 4], []),
        new Node([5, 7, 8], [])
    ]),
    new Node([15], [
        new Node([10, 14], []),
        new Node([15, 17, 18], [])
    ]),
    new Node([25], [
        new Node([21, 22], []),
        new Node([27], [])
    ]),
    new Node([35], [
        new Node([37], [])
    ]),
]);

root.InsertValue(26);
root.InsertValue(29);
Console.WriteLine(root.FindNode(26).WriteKeys());