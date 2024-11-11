namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] insert = Console.ReadLine().Split(" ");
            int n = int.Parse(insert[0]);
            int m = int.Parse(insert[1]);

            int count = 0;
            
            HashSet<string> n_array = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                n_array.Add(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                if (n_array.Contains(Console.ReadLine())) 
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
