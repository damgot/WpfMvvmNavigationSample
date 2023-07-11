using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.Common;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample.Services
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton<ApplicationContext>()
                .AddSingleton<MainViewModel>()

                .AddTransient<ViewModelA>()
                .AddTransient<ViewModelB>()
 
                .BuildServiceProvider());
        }

        public static TViewModel GetViewModelInstance<TViewModel>(ICloseableEvent w, bool initializeContext = true) where TViewModel : IDisposable
        {
            TViewModel VMInstance = Ioc.Default.GetService<TViewModel>();
            if (initializeContext)
                (VMInstance as BaseViewModel)!.InitializeContext();
            w.Closed += (sender, args) =>
            {
                WeakReferenceMessenger.Default.UnregisterAll(VMInstance);
                VMInstance.Dispose();
            };
            return VMInstance;
        }
    }
}
