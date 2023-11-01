using LessonMVVM.ViewModels.PageViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LessonMVVM.Views.Pages
{
    /// <summary>
    /// Interaction logic for GetAllPage.xaml
    /// </summary>
    public partial class GetAllPage : Page
    {
        public GetAllPage()
        {
            InitializeComponent();
            DataContext = new DashboardPageViewModel();
        }
    }
}
