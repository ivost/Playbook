using Common.Library;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;


namespace WPF.Sample.ViewModelLayer
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _LoginMenuHeader = "Login";
        private string _StatusMessage;

        private bool _IsInfoMessageVisible = true;
        public bool IsInfoMessageVisible
        {
            get { return _IsInfoMessageVisible; }
            set
            {
                _IsInfoMessageVisible = value;
                RaisePropertyChanged("IsInfoMessageVisible");
            }
        }

        private string _InfoMessage;
        public string InfoMessage
        {
            get { return _InfoMessage; }
            set
            {
                _InfoMessage = value;
                RaisePropertyChanged("InfoMessage");
            }
        }

        private string _InfoMessageTitle;
        public string InfoMessageTitle
        {
            get { return _InfoMessageTitle; }
            set
            {
                _InfoMessageTitle = value;
                RaisePropertyChanged("InfoMessageTitle");
            }
        }

        public string LoginMenuHeader
        {
            get { return _LoginMenuHeader; }
            set
            {
                _LoginMenuHeader = value;
                RaisePropertyChanged("LoginMenuHeader");
            }
        }

        public string StatusMessage
        {
            get { return _StatusMessage; }
            set
            {
                _StatusMessage = value;
                RaisePropertyChanged("StatusMessage");
            }
        }

        private AppLayer.Service _service = new AppLayer.Service();

        public void ClearInfoMessage()
        {
            StatusMessage = "Ready";
            IsInfoMessageVisible = false;
        }

    }
}
