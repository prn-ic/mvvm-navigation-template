using MvvmTest.Services;
using MvvmTest.Stores;
using System.Windows.Input;

namespace MvvmTest.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        public string? Name { get; set; } = "Первая страница";
        private NavigationStore _navigationStore;

        public HomeViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public RelayCommand AddCommand
        {
            get
            {
                return (new RelayCommand(obj =>
                    _navigationStore.CurrentViewModel = new SubViewModel(_navigationStore)));
            }
        }
    }
}
