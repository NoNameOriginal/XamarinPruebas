namespace XamarinPruebas.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using System.Collections.ObjectModel;
    using Models;
    public class MainViewModel
    {
        #region Properties
        public String Amount {
            get;
            set;
        }
        public ObservableCollection<Rate> Rates {
            get;
            set;
        }
        public Rate SourceRate {
            get;
            set;
        }
        public Rate TargetRate {
            get;
            set;
        }
        public bool IsRunning {
            get;
            set;
        }
        public bool IsEnabled
        {
            get;
            set;
        }
        public String Result {
            get;
            set;
        }
        #endregion
        #region Commands
        public ICommand ConvertCommand {
            get {
                 return new RelayCommand(Convert); 
                }
        }
        void Convert()
        {
            throw new NotImplementedException();
        }
        #endregion
        public MainViewModel()
        {
            
        }

    }
}
