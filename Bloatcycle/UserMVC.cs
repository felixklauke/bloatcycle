namespace Bloatcycle
{
    public class UserMVC
    {
        static void Main(string[] args)
        {
            var userController = new UserController();
            userController.DisplayUserName();
        }
    }
}