namespace csharp_exercise_typeset2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            char l = 'A';
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"How many students for course {l}?");
                int a = int.Parse(Console.ReadLine());
                l++;
                for (int j = 0; j < a; j++)
                {
                    set.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine("Total students: ");
            Console.Write(set.Count);
        }
    }
}