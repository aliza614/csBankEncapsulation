using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csBankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new BankAccount();
            b.Deposit(100.00);
            Console.WriteLine(b.GetBalance());
        }
    }
}
