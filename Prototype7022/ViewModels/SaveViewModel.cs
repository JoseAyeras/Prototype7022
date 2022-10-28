using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    class SaveViewModel : BaseViewModel
    {
        public BaseViewModel lV;
        public SaveViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}
