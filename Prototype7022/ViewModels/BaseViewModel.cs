using Prototype7022.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Prototype7022.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel _selectedViewModel;
        public ICommand UVC { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        
        public virtual BaseViewModel getLast()
        {
            Console.WriteLine("VITAL ALERT: This view model DOES NOT have a last view!!!!!");
            return _selectedViewModel;
        }

        protected void OnPropertyChanged(string args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(args));
        }

        public BaseViewModel(BaseViewModel svm)
        {
            _selectedViewModel = svm;
            UVC = new UpdateViewCommand(svm);
        }
        public BaseViewModel()
        {
            // _selectedViewModel equals null

            UVC = new UpdateViewCommand(this);
        }
    }
}
