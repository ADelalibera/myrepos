using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Versão inicial");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
