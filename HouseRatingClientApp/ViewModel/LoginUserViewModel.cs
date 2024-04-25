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
    internal class LoginUserViewModel : VIewModelBase
    {
        public ICommand CloseWindowCommand { get; }


        public LoginUserViewModel()
        {
            CloseWindowCommand = new LambdaCommand(CloseApp);
        }

        public void CloseApp(object o)
        {
            Application.Current.Shutdown();
        }

        public void EnterIn()
        {
            //MainWindow mainWindow = new MainWindow(); //main Window.xaml
            //EnterAppWindowViewModel viewModel = new EnterAppWindowViewModel();

            //string json = JsonSerializer.Serialize("data.json");
            //File.WriteAllText("data.json", json);

            //var data = new { Login = , Password =  };
            //string jsonString = JsonSerializer.Serialize(data);
            //File.WriteAllText("data.json", jsonString);

            //MessageBox.Show("Вы успешно вошли в аккаунт!");   

            //CloseApp(viewModel);
            //mainWindow.Show();
        }
    }
}
