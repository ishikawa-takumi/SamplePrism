using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private string _text = "Initialize";
        public DelegateCommand ClickCommand { get; set; }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public MainWindowViewModel()
        {
            ClickCommand = new DelegateCommand(OnClick);

        }

        private void OnClick()
        {
            _text = "Clicked";
        }
    }
}
