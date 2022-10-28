using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    public class OptionsViewModel : BaseViewModel
    {
        public BaseViewModel lV;
        public OptionsViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}
