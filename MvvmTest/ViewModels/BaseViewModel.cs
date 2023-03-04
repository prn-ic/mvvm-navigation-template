using MvvmTest.Stores;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmTest.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly NavigationStore _navigationStore;
        public BaseViewModel? CurrentViewModel => _navigationStore.CurrentViewModel;
        public BaseViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private void OnPropertyChanged([CallerMemberName] string viewModelName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(viewModelName));
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
