using System;
using System.Windows.Controls;
using WpfMvvmNavigationSample.Common;
using WpfMvvmNavigationSample.Service;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample.View
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl, ICloseable
    {
        public ViewA()
        {
            InitializeComponent();
            DataContext = ViewModelLocator.GetViewModelInstance<ViewModelA>(this);
        }

        public event EventHandler Closed;

        public void Close()
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
