using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPF.Sample.ViewModelLayer;

namespace WPF.Sample
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;
        private AppLayer.Service _service;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = (MainWindowViewModel)this.Resources["viewModel"];
            _service = new AppLayer.Service();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadApplication();
            _viewModel.ClearInfoMessage();
        }


        public delegate void MyFunction();

        public async Task dispatch(string msg, MyFunction work)
        {
            _viewModel.InfoMessage = msg;
            await Dispatcher.BeginInvoke(new Action(() =>
            {
                work();
            }), System.Windows.Threading.DispatcherPriority.Background);
        }

        public async Task LoadApplication()
        {
            await dispatch("Loading users", _service.LoadUsers);
            await dispatch("Loading history", _service.LoadHistory);
        }
    }
}
