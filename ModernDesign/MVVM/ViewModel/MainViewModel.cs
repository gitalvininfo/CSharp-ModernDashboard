using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public HomeViewModel HomeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { 
                return _currentView; 
            }
            set { 
                _currentView = value;
                OnProperyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;
        }

    }
}
