using System;
using Prodapt.CSharp.Library;


namespace Prodapt.CSharp.Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Login obj1 = new Login();
            var result=obj1.Validation("admin","admin@123");
            Console.WriteLine(result ? "Valid User" : "Invalid User");
                }
    }
}
