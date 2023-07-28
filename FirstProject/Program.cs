namespace FirstProject
{
    class Program
    {
        public static void Main(String[] arguments)
        {
            List<string> collection = new List<string>() {"a", "b", "c" };
            for (int idx = 0; idx < collection.Count; idx++)
                {
                Console.WriteLine(collection[idx]);
            }
        }
    }
}