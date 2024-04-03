namespace labb1_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(2, 2, 2));
            boxList.Add(new Box(5, 5, 5));
            boxList.Add(new Box(7, 7, 7));
            boxList.Add(new Box(10, 10, 10));
            boxList.Add(new Box(10, 10, 10));

            Console.WriteLine("----------------------------");
            Display(boxList);
            Console.WriteLine("----------------------------");

            boxList.Remove(new Box(7, 7, 7));
            Display(boxList);
            Console.WriteLine("----------------------------");

            Box boxToCheck = new Box(2, 2, 2);

            Console.WriteLine("List contains box with Height: {0}, Lenght: {1}, Width: {2}",
                                boxToCheck.Height.ToString(),
                                boxToCheck.Length.ToString(),
                                boxToCheck.Width.ToString(),
                                boxList.Contains(boxToCheck));
            Console.WriteLine("----------------------------");

            Display(boxList);

            Console.ReadKey();

        }
        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("Existing boxes:");
            Console.WriteLine("\nHeigt \tLength \tWidth");

            foreach (Box box in boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                box.Height.ToString(), box.Length.ToString(), box.Width.ToString());
            }
        }
    }
}
