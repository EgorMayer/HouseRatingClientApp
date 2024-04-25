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
        public ICommand CloseWindowCommand { get; }
        public ICommand LoginUserCommand { get; }


        public LoginUserViewModel()
        {
            CloseWindowCommand = new LambdaCommand(CloseApp);
            LoginUserCommand = new LambdaCommand(EnterIn);
        }

        public void CloseApp(object o)
        {
            Application.Current.Shutdown();
        }

        public void EnterIn(object o)
        {
            
        }
    }
}
