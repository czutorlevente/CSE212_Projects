using System.Xml.XPath;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else
            if (Left is not null)
            {
                if (Left.Contains(value) == true)
                {
                    return true;
                }

            }

            if (Right is not null)
            {
                if (Right.Contains(value) == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (Left is null && Right is null)
        {
            return 1;
        }

        int leftHeight = 0;
        int rightHeight = 0;
        if (Left is not null)
        {
            leftHeight = Left.GetHeight();
        }

        if (Right is not null)
        {
            rightHeight = Right.GetHeight();
        }

        if (leftHeight >= rightHeight)
        {
            return leftHeight + 1;
        }
        else
        {
            return rightHeight + 1;
        }
    }
}