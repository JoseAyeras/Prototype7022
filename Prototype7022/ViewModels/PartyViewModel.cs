using System;
using System.Collections.Generic;
using System.Text;

using Prototype7022.ViewModels;

namespace Prototype7022.ViewModels
{
    internal class PartyViewModel : BaseViewModel
    {
        BaseViewModel lV;
        public PartyViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
    }
}