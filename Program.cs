using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green");
            Account1 account2 = new Account("John Blue");

            Console.WriteLine($"account1 name is:{account1.Name}");
            Console.WriteLine($"account2 name is:{account2.Name}");
        }
    }
}
