using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.Services;

namespace WpfMvvmNavigationSample.Common
{
    public class ApplicationContext
    {
        public NavigationService NavigationService { get; set; } = new NavigationService();
    }
}
