namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numbers = new List<int>();

           
            int num=0;

            
            {
                num++;
                numbers.Add(num);

            } while (num < 100);

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            
            Console.WriteLine("Increase:");


            
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i < numbers.Count && i>0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            
         
        }
    }
}
