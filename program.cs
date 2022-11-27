using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            var randomName = NamesGenerator.GenerateName();

            Console.WriteLine("Random name: ");
            Console.WriteLine(randomName);
            Console.ReadLine();
      
            
        }
    }
}
