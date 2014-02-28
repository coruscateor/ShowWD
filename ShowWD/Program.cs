using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowWD
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Environment.CurrentDirectory);

            if(args.Length > 0)
            {

                if(args[0] == "-w")
                    Console.ReadLine();

            }

        }

    }

}
