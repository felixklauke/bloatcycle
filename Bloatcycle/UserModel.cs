namespace Bloatcycle
{
    public class UserModel
    {
        public string UserName { get; set; }
        
        public UserModel(string userName)
        {
            UserName = userName;
        }
    }
}