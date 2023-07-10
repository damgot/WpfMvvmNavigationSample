using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.Common;

namespace WpfMvvmNavigationSample.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties
        #region WelcomeText
        private string _welcomeText;
        public string WelcomeText
        {
            get
            {
                return _welcomeText;
            }

            set
            {
                if (_welcomeText == value)
                {
                    return;
                }

                _welcomeText = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #endregion

        #region Constructor and Initializer
        public MainViewModel(ApplicationContext appContext)
		{
			AppContext = appContext;
            AppContext.NavigationService.NavigateTo<MainViewModel>();
            WelcomeText = "Welcome Home";
        }

		public override void InitializeContext()
		{
			base.InitializeContext();
		}
        #endregion


        #region RelayCommand
        public RelayCommand ViewACommand => new RelayCommand(() => AppContext.NavigationService.NavigateTo<ViewModelA>());
        public RelayCommand ViewBCommand => new RelayCommand(() => AppContext.NavigationService.NavigateTo<ViewModelB>());
        #endregion
    }
}
