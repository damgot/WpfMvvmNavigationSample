using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmNavigationSample.ViewModel;

namespace WpfMvvmNavigationSample.Services
{
    public class NavigationService : ObservableObject
    {
        private Stack<object> _stackVM = new Stack<object>();

        #region CurrentViewModel
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }

            set
            {
                if (_currentViewModel == value)
                {
                    return;
                }

                _currentViewModel = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public void NavigateTo<T>() where T : BaseViewModel
        {
            if (CurrentViewModel != null && _stackVM != null)
            {
                _stackVM.Push(CurrentViewModel);
            }
            //Get the type of ViewModel without calling the constructor
            CurrentViewModel = FormatterServices.GetUninitializedObject(typeof(T));
        }

        public void NavigateToParent()
        {
            if (_stackVM != null && _stackVM.Count > 0)
            {
                CurrentViewModel = _stackVM.Pop();
            }
        }
    }
}
