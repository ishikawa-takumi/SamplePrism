using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public DelegateCommand ClickCommand { get; set; }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public MainWindowViewModel()
        {
            ClickCommand = new DelegateCommand(OnClick);
        }

        private void OnClick()
        {
            MessageBox.Show("Clicked");
        }
    }
}
