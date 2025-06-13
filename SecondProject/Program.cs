using System.Text;

namespace SecondProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Minh họa lấy giá trị từ " +
                "outside arguments");
            if (args.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < args.Length; i++) 
                {
                    int item = int.Parse(args[i]);
                    sum += item;
                    Console.WriteLine(item);
                }
                Console.WriteLine("=>SUM={0}", sum);
            }
            Console.ReadLine();
        }
    }
}