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
                var res = new Calculo().Somar(5, 3, 1);
                Console.WriteLine("resultado => {0}",res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
