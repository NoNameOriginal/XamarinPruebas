namespace XamarinPruebas.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using System.Collections.ObjectModel;
    using System;
    using Models;
    using System.ComponentModel;
    using System.Net.Http;

    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Attributes
        bool _isRunning;
        string _result;
        #endregion
        #region Properties
        public string Amount {
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
            get
            {
                return _isRunning;
            }
            set
            {
                if(_isRunning != value)
                {
                    _isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(IsRunning)));               
                }
            }
        }
        public bool IsEnabled
        {
            get;
            set;
        }
        public string Result {
            get
            {
                return _result;
            }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(Result)));
                }
            }
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
        #region Constructors
        public MainViewModel()
        {
            LoadRates();
        }

        void LoadRates()
        {
            IsRunning = true;
            Result = "Loading Rates...";
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://apiexchangerates.azurewebsites.net");
                var controller = "/api/Rates";

            }
            catch (Exception ex)
            {
                IsRunning = false;
                Result = ex.Message;

            }
        }
        #endregion

    }
}
