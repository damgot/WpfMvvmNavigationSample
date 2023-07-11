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
using WpfMvvmNavigationSample.Common;
using WpfMvvmNavigationSample.Services;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample.View
{
    /// <summary>
    /// Interaction logic for ViewB.xaml
    /// </summary>
    public partial class ViewB : UserControl, ICloseable
    {
        public ViewB()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.GetViewModelInstance<ViewModelB>(this);
        }

        public event EventHandler Closed;

        public void Close()
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
