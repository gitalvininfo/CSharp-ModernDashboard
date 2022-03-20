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

        public RelayCommand HomeViewComamnd { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

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
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;


            HomeViewComamnd = new RelayCommand(o => {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o => {
                CurrentView = DiscoveryVM;
            });

        }

    }
}
