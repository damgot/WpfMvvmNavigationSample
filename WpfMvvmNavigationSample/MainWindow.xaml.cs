using System.Windows;
using WpfMvvmNavigationSample.Common;
using WpfMvvmNavigationSample.Service;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICloseable
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.GetViewModelInstance<MainViewModel>(this, false);
        }
    }
}
