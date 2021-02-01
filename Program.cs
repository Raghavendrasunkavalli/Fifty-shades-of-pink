using System;

namespace Fifty_shades_of_pink
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the number of packages: ");
                string n1 = Console.ReadLine();
                int n = Convert.ToInt32(n1);
                int count = 0;
            for (int i = 1; i <= n; i++)
            {
                string x = Console.ReadLine().ToLower();
                if (x.Contains("pink") || x.Contains("rose"))
                {
                    count++;
                }
            }    
            if(count == 0)
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
            else
            {
                Console.WriteLine(count);
            }


            

         
            
        }
    }
}
