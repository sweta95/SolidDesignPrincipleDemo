using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoose moose = new Moose();
            // Create adapter and place a request
            ICharacter target = new MooseAdapter(moose);
            target.Run();
            // Wait for user

            Console.ReadKey();
        }
    }
}
