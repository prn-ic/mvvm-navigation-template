using MvvmTest.Stores;
using MvvmTest.ViewModels;
using System.Windows;
using System.Windows.Navigation;

namespace MvvmTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new BaseViewModel(navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
