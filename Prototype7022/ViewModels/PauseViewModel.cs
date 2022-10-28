using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    public class PauseViewModel : BaseViewModel
    {
        public BaseViewModel lV;
        public PauseViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}
