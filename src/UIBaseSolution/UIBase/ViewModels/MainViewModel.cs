using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBase.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public INotifyPropertyChanged currentViewModel;

        [RelayCommand]
        public void ToLogin()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetRequiredService(typeof(LoginControlViewModel));
        }
        [RelayCommand]
        public void ToChangePassword()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetRequiredService(typeof(ChangePasswordControlVIewModel));
        }
        [RelayCommand]
        public void ToSignUp()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetRequiredService(typeof(SignUpControlVIewModel));
        }

        public MainViewModel()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetRequiredService(typeof(LoginControlViewModel));
        }
    }
}
