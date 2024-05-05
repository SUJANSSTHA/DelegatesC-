namespace Delegates

    
/*
 is is also called function pointer.
Delegate signature should be same as the method signature referencing by a delegate

 */

    //Delegate can point to a parameterized method or non paramterized method.
    //Delagate has no implementation means no body with()


// Delefate is a type which holds a method's reference in an object.
    
{
    public delegate void Calculation(int a, int b);
    internal class Program
    {
        public static void Addition (int a, int b)
        {
            int result = a + b;
            Console.WriteLine ("Additon result is : {0}",result);
        }
      
      
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is : {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is : {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is : {0}", result);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Calculation obj = new Calculation(Program.Addition);
            obj.Invoke(20,30);

        }
    }
}
