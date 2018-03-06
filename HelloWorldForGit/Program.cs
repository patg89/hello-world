using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            new AddedClass().SayHello();

            Console.ReadLine();
        }
    }

    class AddedClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
