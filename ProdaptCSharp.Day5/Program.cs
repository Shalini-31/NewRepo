using System; 
    namespace ProdaptCSharp.Day5
    
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Shalini";
            string description = " hi its me hello";
            //sub string 
            Console.WriteLine(name.Substring(1,6));
            //to upper to lower 
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            //trim() contain()
            Console.WriteLine(description.Contains("hello"));//return bool
            Console.WriteLine(description.TrimStart());//remove space at beginning and end not middle.
        }
    }
}
