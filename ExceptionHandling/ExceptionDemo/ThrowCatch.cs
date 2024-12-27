namespace ExceptionDemo
{
    public class ThrowCatch
    {
        internal  void Method2()
        {
            try
            {
                Console.WriteLine("Method2");
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("CatchM2");
                // resets the stack trace Coming from Method 1 and propogates it to the caller(Main)
                throw ex;
            }
        }

        internal  void Method1()
        {
            try
            {
                Console.WriteLine("Method1 try");
                throw new Exception("Inside Method1");
            }
            catch (Exception)
            {
                Console.WriteLine("Catchm1");
                throw;
            }
        }
    }
}
