using LessonMVVM.ViewModels.WindowViewModels;
using LessonMVVM.Views.Windows;
using System.Windows;

namespace LessonMVVM;


public partial class App : Application
{
    private void Main(object sender, StartupEventArgs e)
    {

        // DOWORK

        var mainView = new MainView();
        mainView.DataContext = new MainViewModel();
        mainView.ShowDialog();



    }
}
