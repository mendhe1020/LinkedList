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
                
                Console.WriteLine("1.Create a Linked List / n2.Add Reversed order of Elements \n3.Appending the Elemente \n 4. Insert At Required Position \n5.Delete the first element in linked list  \n 6. Deleting Last Element ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;

                    case 2:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        list.Display();
                        break;

                    case 3:
                        list.Appending(56);
                        list.Appending(30);
                        list.Appending(70);
                        list.Display();
                        break;

                    case 4:
                        list.InsertAtParticularPosition(16, 46);
                        list.Display();
                        break;

                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeletingFirstPosition();
                        list.Display();
                        break;

                    case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeletingLastPosition();
                        list.Display();
                        break;
                }
            }
        }
    }
}