using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using Prototype7022.Commands;

namespace Prototype7022.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _selectedViewModel = new HomeViewModel(this);
            UVC = new UpdateViewCommand(this);
        }
    }
}
