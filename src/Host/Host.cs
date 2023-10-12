using Model;

namespace Host
{
    internal class Host
    {
        static void Main(string[] arg)
        {

            Account<long> myAccount = new Account<long>();
            myAccount.Id = 100L;

            //int idLocal = (int)(long)myAccount.Id; // в лонг, а потом в инт



            /*try
            {
                throw new InvalidOperationException("Do not know what to do");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                //throw; // на рус -> сроу
                //throw new Exception("MyException"); // not good
                //throw e; //not good

                throw;
            }

            Console.WriteLine("FINISH");*/
        }
    }
}