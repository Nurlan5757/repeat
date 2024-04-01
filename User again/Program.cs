using User_again.Models;

namespace User_again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User ("nURLAN  ","  aBBASOV","Nurlan123");
            
            user.ChangePassword("Nurlan123", "abbasov123");

           /* Console.WriteLine(user.UserName);*/
        }
    }
}
