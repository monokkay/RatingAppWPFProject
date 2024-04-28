using RatingAppWPFProject.ViewModel.Base;
using RatingAppWPFProject.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RatingAppWPFProject.ViewModel
{
    public class LoginUserViewModel : VIewModelBase
    {
        private string _userLogin;
        public string UserLogin
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
        public string UserPassword
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
            CloseWindowCommand = new LambdaCommand(CloseApp); //это все для главного экрана(но этот метод еще использую и для закрытия на главном окне!)
            LoginUserCommand = new LambdaCommand(LogIn);
        }

        public void CloseApp(object o)
        {
            Application.Current.Shutdown();
        }

        //public void ShowdownApp(object o)
        //{
        //    Application.Current.
        //}

        public void LogIn(object o)
        {
            Application.Current.Shutdown();
        }
    }
}
