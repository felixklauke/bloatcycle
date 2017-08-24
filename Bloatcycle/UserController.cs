namespace Bloatcycle
{
    public class UserController
    {
        private readonly UserModel _model;
        private readonly UserView _userView;

        public UserController()
        {
            _userView = new UserView();
            _model = new UserModel("Lütti");
        }

        public void DisplayUserName()
        {
            _userView.DisplayName(_model.UserName);
        }
    }
}