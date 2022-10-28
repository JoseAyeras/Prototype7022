using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    class ShopViewModel : BaseViewModel
    {
        BaseViewModel lV;
        public ShopViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}
