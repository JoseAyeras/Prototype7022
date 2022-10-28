using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.ViewModels
{
    public class LoadViewModel : BaseViewModel
    {
        public BaseViewModel lV;
        public LoadViewModel(BaseViewModel svm) : base(svm)
        {
            lV = svm.SelectedViewModel;
        }
        public override BaseViewModel getLast()
        {
            return lV;
        }
        public void DeleteSave()
        {
            Console.WriteLine("ALERT: DeleteSave NOT implemented!!!");
            Console.WriteLine("Save deleted?");
        }
    }
}
