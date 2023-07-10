using System.Windows;
using System.Windows.Controls;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample.Service
{
    public class ViewModelDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MainViewTemplate { get; set; }
        public DataTemplate ViewATemplate { get; set; }
        public DataTemplate ViewBTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is MainViewModel)
                return MainViewTemplate;
            else if (item is ViewModelA)
                return ViewATemplate;
            else if (item is ViewModelB)
                return ViewBTemplate;

            // Return default DataTemplate if no match was found
            return base.SelectTemplate(item, container);
        }
    }
}
