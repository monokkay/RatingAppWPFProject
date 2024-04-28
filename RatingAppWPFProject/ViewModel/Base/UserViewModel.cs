using RatingAppWPFProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.ViewModel.Base
{
    public class UserViewModel : VIewModelBase
    {
        private ObservableCollection<UserRegistration> _user;
        public ObservableCollection<UserRegistration> User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    OnPropertyChanged(nameof(User));
                }
            }
        }
        public UserViewModel()
        {
            User = new ObservableCollection<UserRegistration>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
