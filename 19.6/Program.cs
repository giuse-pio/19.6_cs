namespace _19._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> eta = new List<int>();
            int n;
            Console.WriteLine("inserisci l'età di una persona");
            while (int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                if (n <= 0)
                {
                    break;
                }
                eta.Add(n);
            }
            
            Console.WriteLine();
            for (int i = 0; i < eta.Count; i++)
            {
                int pos = i + 1;
                if (eta[i] > 18)
                {
                    Console.WriteLine($"La persona in posizione {pos} ha {eta[i]}");
                }
            }
        }
    }
}
