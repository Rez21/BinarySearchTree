using BinarySearchTree;

class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> binarySearchTreeOne = new BinarySearchTree<int>();
        binarySearchTreeOne.Add(56);
        binarySearchTreeOne.Add(30);
        binarySearchTreeOne.Add(70);
        binarySearchTreeOne.Add(22);
        binarySearchTreeOne.Add(40);
        binarySearchTreeOne.Add(11);
        binarySearchTreeOne.Add(16);
        binarySearchTreeOne.Add(3);
        binarySearchTreeOne.Add(60);
        binarySearchTreeOne.Add(95);
        binarySearchTreeOne.Add(65);
        binarySearchTreeOne.Add(63);
        binarySearchTreeOne.Add(67);

        Console.WriteLine("No of elements in binary search tree are : {0} ", binarySearchTreeOne.Size());
    }
}