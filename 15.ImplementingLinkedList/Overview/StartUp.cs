namespace Overview
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            var myList = new MyList(5);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            Console.WriteLine(myList.Coint);
            myList.RemoveAt(2);
            for (int i = 0; i < myList.Coint; i++)
            {
                Console.WriteLine($"elemenets in MyList {myList[i]}");
            }
            Console.WriteLine($"Testing Clear method");
            myList.Clear();
            Console.WriteLine($"List count after clear method {myList.Coint}");


            Console.WriteLine("================STACK=============");
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Count);
        }
    }
}