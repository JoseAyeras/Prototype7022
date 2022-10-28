using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    class RecordsViewModel : BaseViewModel
    {
        BaseViewModel lV;
        public RecordsViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}
