using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.Common;

namespace WpfMvvmNavigationSample.ViewModel
{
    public class ViewModelA : BaseViewModel
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
        public ViewModelA(ApplicationContext appContext)
		{
			AppContext = appContext;
            WelcomeText = "I'm ViewModel A";
		}

		public override void InitializeContext()
		{
			base.InitializeContext();
		}
        #endregion
    }
}
