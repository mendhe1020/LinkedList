namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");

            bool flag = true;
            LinkedList list = new LinkedList();
            while (flag)
            {
                
                Console.WriteLine("1.Create a Linked List ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                }
            }
        }
    }
}