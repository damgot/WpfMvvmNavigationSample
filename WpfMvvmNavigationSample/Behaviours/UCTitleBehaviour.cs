using System.Windows.Controls;
using System.Windows;
using WpfMvvmNavigationSample.Helpers;

namespace WpfMvvmNavigationSample.Behaviours
{
    public static class UCTitleBehaviour
    {
        public static readonly DependencyProperty WindowTitleProperty = DependencyProperty.RegisterAttached(
        "WindowTitle",
        typeof(string),
        typeof(UCTitleBehaviour),
        new PropertyMetadata(null, OnWindowTitleChanged));

        public static string GetWindowTitle(DependencyObject obj)
        {
            return (string)obj.GetValue(WindowTitleProperty);
        }

        public static void SetWindowTitle(DependencyObject obj, string value)
        {
            obj.SetValue(WindowTitleProperty, value);
        }

        private static void OnWindowTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControl control = d as UserControl;
            if (!control.IsLoaded)
                control.Loaded += new RoutedEventHandler(SetTitle);
            else
                SetTitle(control);
        }

        private static void SetTitle(object sender, RoutedEventArgs e)
        {
            UserControl control = sender as UserControl;
            SetTitle(control);
            control.Loaded -= new RoutedEventHandler(SetTitle);
        }

        private static void SetTitle(UserControl c)
        {
            Window parent = UIHelper.TryFindParent<Window>(c);
            if (parent != null)
            {
                parent.Title = (string)GetWindowTitle(c);
            }
        }
    }
}
