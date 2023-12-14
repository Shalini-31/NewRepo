using System; 
    namespace ProdaptCSharp.Day5
    
{
    public class Program
    {
        // static method called only by class name 
        static string city; 

        public void getdata()
        {
            Console.Write("enter a city:");
            city = Console.ReadLine();
           
        }
        public static void printdata() {
            Console.WriteLine($"city:{city}");
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
            obj.getdata();
            obj2.getdata();
            Program.printdata();









            // static method called only by class name 



        }
    }
}
