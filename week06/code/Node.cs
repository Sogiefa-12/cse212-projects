public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // Check for duplicate values
        if (this.Contains(value))
        {
            return; // Duplicate value, do not insert
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        Node? currentNode = this;

        while (currentNode != null)
        {
            if (currentNode.Data == value)
            {
                return true; // Value found
            }
            else if (value < currentNode.Data)
            {
                currentNode = currentNode.Left; // Move to the left child
            }
            else
            {
                currentNode = currentNode.Right; // Move to the right child
            }

           
        }
        
         return false; // Value not found
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = (Left is null) ? 0 : Left.GetHeight();
        int rightHeight = (Right is null) ? 0 : Right.GetHeight();
        return 1 + Math.Max(leftHeight, rightHeight); // Replaced with the correct return statement(s)
    }
}