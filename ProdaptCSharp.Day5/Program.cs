using System; 
    namespace ProdaptCSharp.Day5
    
{
    public class Program
    {
         static int count = 10;
        int stdid;

        public Program()
        {
            count++;
            stdid = count;
        }

        static Program()
        {
            count = 100;
        }

        
        public static void Main(string[] args)
        {
            //    string name = "Shalini";
            //    string description = " hi its me hello";
            //    //sub string 
            //    Console.WriteLine(name.Substring(1,6));
            //    //to upper to lower 
            //    Console.WriteLine(name.ToLower());
            //    Console.WriteLine(name.ToUpper());
            //    //trim() contain()
            //    Console.WriteLine(description.Contains("hello"));//return bool
            //    Console.WriteLine(description.TrimStart());//remove space at beginning and end not middle.

            //    x = 20;
            //    Console.WriteLine(x);//Static example 

            //    //Rename Ctrl+R Ctrl+R

            Program obj=new Program();
            Program obj2 = new Program();
            Console.WriteLine($" static constructor called {obj.stdid}");
            Console.WriteLine($"instance of the class{obj2.stdid}");
        }
    }
}
