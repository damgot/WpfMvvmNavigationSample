using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.Common;

namespace WpfMvvmNavigationSample.ViewModel
{
    public class BaseViewModel : ObservableRecipient, IDisposable
    {
        public ApplicationContext AppContext { get; set; }

        public virtual void Dispose()
        {

        }

        public virtual void InitializeContext()
        {
            if (AppContext == null) { return; }

            //Here you can initialize a DB contexte for example
        }

        public RelayCommand<ICloseable> ExitCommand => new RelayCommand<ICloseable>(w =>
        {
            if (w != null)
                Close(w);
        });

        public RelayCommand<ICloseable> ReturnCommand => new RelayCommand<ICloseable>(w =>
        {
            if (w == null) return;
            if (AppContext?.NavigationService != null)
                AppContext.NavigationService.NavigateToParent();
            Close(w);
        });

        public void Close(ICloseable w)
        {
            if (w != null)
                w.Close();
        }
    }
}
