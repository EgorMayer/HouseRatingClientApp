using HouseRatingClientApp.Infrastructure.Commands.Base;
using HouseRatingClientApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HouseRatingClientApp.ViewModel
{
    public class LoginUserViewModel : VIewModelBase
    {
        private string _userLogin;
        private string UserLogin
        {
            get => _userLogin;
            set
            {
                if (_userLogin != value)
                {
                    _userLogin = value;
                    OnPropertyChanged(nameof(UserLogin));
                }
            }
        }

        private string _userPassword;
        private string UserPassword
        {
            get => _userPassword;
            set
            {
                if (_userPassword != value)
                {
                    _userPassword = value;
                    OnPropertyChanged(nameof(UserPassword));
                }
            }
        }


        public ICommand CloseWindowCommand { get; }
        public ICommand LoginUserCommand { get; }


        public LoginUserViewModel()
        {
            UserLogin = string.Empty;
            UserPassword = string.Empty;
            CloseWindowCommand = new LambdaCommand(CloseApp);
            LoginUserCommand = new LambdaCommand(LogIn);
        }

        public void CloseApp(object o)
        {
            Application.Current.Shutdown();
        }

        public void LogIn(object o)
        {
            //User
        }
    }
}
