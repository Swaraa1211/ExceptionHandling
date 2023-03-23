namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            int b= 0;
            int c = a / b;
            Console.WriteLine(c);*/
            int[] arr = { 1, 2, 3 };
            try
            {
                Console.WriteLine(arr[4]);
            }
            catch (Exception ae)
            {
                Console.WriteLine (ae.Message);
                Console.WriteLine ("Out of bound");
            }
            finally
            {
                Console.WriteLine("Finally called");
            }
            
            
            int a = 10;
            int b = 0;
            try
            {
                int c = a / b;
            }
            //catch - exception wont be displayed
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Cant Divide by Zero " +de.Message);
            }
            //specific excetion is preferred more than general
            //exception e should be the last one
            catch(Exception e) 
            {
                Console.WriteLine("Error msg " + e.Message);
                Console.WriteLine("Catch called!");
            }
            finally
            {
                Console.WriteLine("Finally called!");
            }
        }
    }
}