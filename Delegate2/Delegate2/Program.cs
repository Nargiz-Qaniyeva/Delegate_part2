using Delegate2.Models;
using System;

namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte role;
            bool isNum;
            do
            {
                Console.WriteLine("****_Menu_****");
                Console.WriteLine("Role (1. Admin, 2.Member):");
                string roleStr = Console.ReadLine();
                isNum = byte.TryParse(roleStr, out role);
            } while (!isNum || !Enum.IsDefined(typeof(Role), role));
        }
    }
}
