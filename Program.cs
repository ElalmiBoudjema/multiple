using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace multiple
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i <= 5; i++)

            {



               //this is my first p   
                    
                
                    
                    Console.WriteLine("\n\t multiple {0}",i);
                if (i > 2)
                    continue;

                for (int j = 0; j <= 10; j++)
                {
                    
                        

                    Console.WriteLine("\n\t\t{0}/{1}={2}",i,j,i*j);
                   

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
